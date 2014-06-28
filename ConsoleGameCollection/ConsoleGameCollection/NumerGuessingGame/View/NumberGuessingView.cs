using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Controller;

namespace ConsoleGameCollection.NumerGuessingGame.View {
    class NumberGuessingView : IView {
        // Draws everything to the screen. Communicates with the user

        private NumberGuessingController controller;

        public NumberGuessingView() {
            Menu(out controller);

        }

        public void Menu(out NumberGuessingController controller) {
            int input, numberOfPlayers;
            
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
                        controller = new NumberGuessingController(input, 1);
                        break;
                    case 2:
                        Console.Write("How many players?\n" + 
                                      "input > ");
                        int numberOfPlayers = int.Parse(Console.WriteLine());
                        controller
                        break;
                    case 3:
                        numberOfPlayers = 1;
                        break;
                }


                if (input < 0 || input > 3) {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                } else if(input == 1)
                else
                    

            } while(input != 0);
        }

        public void DrawGame() {

        }
    }
}
