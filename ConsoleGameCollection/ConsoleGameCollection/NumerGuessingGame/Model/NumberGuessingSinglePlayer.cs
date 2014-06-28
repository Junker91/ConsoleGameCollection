using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {
    public class NumberGuessingSinglePlayer : NumberGuessingGameMode {
        private Player _player;
        private int _minimunValue;
        private int _maximunValue;
        private int _correctValue;

        public NumberGuessingSinglePlayer(Player player, int minimunValue, int maximunValue) {
            this._player = player;
            this._minimunValue = minimunValue;
            this._maximunValue = maximunValue;


            StartGame();
        }

        public void StartGame() {
            bool gameWon = false;
            int input;

            Random randNum = new Random();
            _correctValue = randNum.Next(_minimunValue, _maximunValue);

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("You have {0} tries to find the right number between {1} and {2}", _player.Lives, _maximunValue, _maximunValue);

            do{
                Console.WriteLine("Take a guess");
                input = int.Parse(Console.ReadLine());

                if (input < _correctValue) {
                    Console.WriteLine("The value must be higher!");
                    _player.Lives -= 1;
                }
                else if (input > _correctValue) {
                    Console.WriteLine("The value must be smaller");
                    _player.Lives -= 1;
                }
                else {
                    gameWon = true;
                }



            } while (!gameWon && _player.Lives > 0);

            if(_player.Lives <= 0){
                Console.WriteLine("You did not find the number within the timeline, better luck next time\n" +
                                  "Press any key to continue.");
            }
            else {
                Console.WriteLine("Congratulations, you won!\n" +
                                  "Press any key to continue");
            }

            Console.ReadKey();
                

        }
    }
}
