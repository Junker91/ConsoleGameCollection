using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {

    /* This class is the main collection class for all the model classes. (sort of like the workspace)
     */
    class GameNumberGuessing {

        private NumberGuessingGameMode _gameMode;

        public NumberGuessingGameMode GameMode {
            get {
                return _gameMode;
            }
            set {
                _gameMode = value;
            }
        }

        public GameNumberGuessing(int input, List<NumberGuessingPlayer> playerList, int minimumValue, int maximumValue) {
            GameModeChoice(input, playerList, minimumValue, maximumValue);
        }

        public void GameModeChoice(int input, List<NumberGuessingPlayer> playersList, int minimumValue, int maximumValue) {
            switch (input) {
                case 1:
                    _gameMode = new NumberGuessingSinglePlayer(playersList, minimumValue, maximumValue);
                    break;
                case 2:
                    _gameMode = 
                    break;
                case 3:
                    
                    break;
            }
        }
    }
}
