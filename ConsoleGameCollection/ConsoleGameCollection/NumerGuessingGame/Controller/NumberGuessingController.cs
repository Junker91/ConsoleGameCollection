using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Controller {
    public class NumberGuessingController {
        // Communication between model and view layer.
        // Singleton.

        public static void GameModeChoice(int input) {
            switch (input) {
                case 1:
                    SinglePlayerMode();
                    break;
                case 2:
                    Multiplayer();
                    break;
                case 3:
                    VersusAI();
                    break;
            }
        }

        private void SinglePlayerMode() {

        }
    }
}
