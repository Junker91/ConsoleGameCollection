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
        

        /// <param name="player">The name of the player </param>
        /// <param name="minimunValue">The minimum value of the interval that should be guessed in</param>
        /// <param name="maximunValue">The maximum value of the interval that should be guessed in</param>
        public NumberGuessingSinglePlayer(Player player, int minimunValue, int maximunValue) {
            this._player = player;
            this._minimunValue = minimunValue;
            this._maximunValue = maximunValue;
            Random randNum = new Random();

            //Adds a value (the number that should be found) in the dictionary on the players space. Becomes more useful in multiplayer game.
            base._correctValueDic.Add(_player.Name, randNum.Next(_minimunValue, _maximunValue));

            StartGame();
        }

        //Method that plays out the singleplayer game. For each try it removes a life, until there are no more lives.
        public void StartGame() {
            bool gameWon = false;
            int input;

            int _correctValue = base._correctValueDic[_player.Name];

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("You have {0} tries to find the right number between {1} and {2}", _player.Lives, _maximunValue, _maximunValue);

            //Keeps running until the player either wins or loses the game
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
                Console.WriteLine("You did not find the number within the timeline. The number was {0}, better luck next time\n" +
                                  "Press any key to continue.", _correctValue);
            }
            else {
                Console.WriteLine("Congratulations you found the number {0} and won the game!\n" +
                                  "Press any key to continue", _correctValue);
            }
            Console.ReadKey();
                

        }
    }
}
