using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Controller;

namespace ConsoleGameCollection.NumerGuessingGame.View {
    class NumberGuessingView : IView {
        // Draws everything to the screen. Communicates with the user

        public void Menu() {
            int input;
            
            do {
                Console.Clear();
                Console.WriteLine("How do you want to play?");
                Console.WriteLine("\nHow do you want to play?\n");
                Console.WriteLine("1. Single Player");
                Console.WriteLine("2. Multiplayer");
                Console.WriteLine("3. Against AI");
                Console.WriteLine("0. Back to main menu\n");
                Console.Write("Input > ");
                input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 3) {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                }
                else
                    NumberGuessingController.GameModeChoice(input);

            } while(input != 0);
        }

        public void DrawGame() {

        }
    }
}
