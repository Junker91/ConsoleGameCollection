using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Controller;
using ConsoleGameCollection.NumerGuessingGame.Model;

namespace ConsoleGameCollection.NumerGuessingGame.View {
    class NumberGuessingView : IView {
        // Draws everything to the screen. Communicates with the user

        private NumberGuessingController controller;


        public NumberGuessingView() {
            Menu(controller);

        }

        public void Menu(NumberGuessingController controller) {
            int input, numberOfPlayers = 0;
            
            do {
                Console.Clear();
                Console.WriteLine("\nNumber Guessing Game!\n");
                Console.WriteLine("\nHow do you want to play?\n");
                Console.WriteLine("1. Single Player");
                Console.WriteLine("2. Multiplayer");
                Console.WriteLine("3. Against AI");
                Console.WriteLine("0. Back to main menu\n");
                Console.Write("Input > ");
                input = int.Parse(Console.ReadLine());

                switch(input) {
                    case 1:
                        numberOfPlayers = 1;
                        break;
                    case 2:
                        Console.Write("How many players?\n" + 
                                      "input > ");
                        numberOfPlayers = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        numberOfPlayers = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }

                if (input > 0 && input <= 3) {
                    controller = new NumberGuessingController(input, CreatePlayers(1, numberOfPlayers));
                }
                    

            } while(input != 0);
        }

        public List<NumberGuessingPlayer> CreatePlayers(int playersCreated, int numberOfPlayers) {
            NumberGuessingPlayer player = new NumberGuessingPlayer();

            if (playersCreated < numberOfPlayers)
                CreatePlayers(playersCreated + 1, numberOfPlayers);
            
            return
        }

        public void DrawGame() {

        }
    }
}
