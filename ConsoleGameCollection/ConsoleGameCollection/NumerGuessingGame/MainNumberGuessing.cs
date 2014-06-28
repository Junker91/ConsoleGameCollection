using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Controller;
using ConsoleGameCollection.NumerGuessingGame.View;

namespace ConsoleGameCollection.NumerGuessingGame {

    /* Main method for number guessing game
     */
    class MainNumberGuessing{

        public MainNumberGuessing() {
            NumberGuessingController.GetInstance().CreateGame();

            new NumberGuessingView();
        }
    }
}
