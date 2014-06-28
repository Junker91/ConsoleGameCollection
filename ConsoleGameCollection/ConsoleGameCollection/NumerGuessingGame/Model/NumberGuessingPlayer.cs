using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {
    public class NumberGuessingPlayer : Player {
        

        public override int Score {
            get {
                return base.score;
            }
            set {
                base.score = value;
            }
        }

        public override int Lives {
            get {
                return base.lives;
            }
            set {
                base.lives = value;
            }
        }

    }
}
