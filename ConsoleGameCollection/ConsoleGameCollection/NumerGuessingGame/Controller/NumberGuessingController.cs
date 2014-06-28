using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Model;

namespace ConsoleGameCollection.NumerGuessingGame.Controller {
    /* This is the main controller. It connects all other controllers form the number guessing game.
     */
    public class NumberGuessingController {

        private static NumberGuessingController instance;
        private static GameNumberGuessing game;

        public static NumberGuessingController GetInstance() {
            if (instance == null)
                instance = new NumberGuessingController();

            return instance;
        }

        public GameNumberGuessing GetGame() {
            if(game == null)
                game = new GameNumberGuessing();

            return game;
        }

        public void CreateGame() {
            if (game == null)
                game = new GameNumberGuessing();
        }

    }
}
