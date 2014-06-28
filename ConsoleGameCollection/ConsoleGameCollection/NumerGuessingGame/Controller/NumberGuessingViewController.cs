using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Model;

namespace ConsoleGameCollection.NumerGuessingGame.Controller {
    class NumberGuessingViewController {

        public NumberGuessingPlayerCreation playerCreation;
        private GameNumberGuessing game;

        public NumberGuessingViewController() {
            playerCreation = new NumberGuessingPlayerCreation();
        }

        public void CreateGame(int input, List<NumberGuessingPlayer> playerList, int minimumValue, int MaximumValue) {
            game = new GameNumberGuessing(input, playerList, minimumValue, MaximumValue);
        }

    }
}
