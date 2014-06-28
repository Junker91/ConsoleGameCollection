using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Controller {
    public class NumberGuessingController {
        // Communication between model and view layer.

        private NumberGuessingGameMode gameMode;

        public NumberGuessingController(int gameModeInput) {
            
            GameModeChoice(gameModeInput);
        }

        public void GameModeChoice(int input) {
            switch (input) {
                case 1:
                    gameMode = new NumberGuessingSinglePlayer();
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
            }
        }

    }
}
