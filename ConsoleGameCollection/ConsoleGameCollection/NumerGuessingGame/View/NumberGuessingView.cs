using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Controller;
using ConsoleGameCollection.NumerGuessingGame.Model;

namespace ConsoleGameCollection.NumerGuessingGame.View {
    class NumberGuessingView {
        // Draws everything to the screen. Communicates with the user

        private NumberGuessingViewController controller;

        public NumberGuessingView() {
            controller = new NumberGuessingViewController();
            Menu();
        }

        private void Menu() {
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
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }

                CreatePlayers(numberOfPlayers);

                
            } while(input != 0);
        }

        private void CreatePlayers(int numberOfPlayers) {
            int lives = 1;
            string name;
            for (int i = 0; i < numberOfPlayers; i++) {

                Console.Write("Enter the name of player {0}\n" +
                              "input > ", i + 1);
                name = Console.ReadLine();

                if (numberOfPlayers == 1) {
                    Console.Write("How many lives / tries does player {0} wants?\n" + 
                                  "input > ", i + 1);
                    lives = int.Parse(Console.ReadLine());
                }
                controller.playerCreation.CreatePlayer(name, lives);
            }
        }
    }
}
