using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {
    public abstract class NumberGuessingGameMode : GameMode {
        /* Contains all the variables that the Number Guessing Game modes have in common.
         */

        protected Dictionary<string, int> _correctValueDic = new Dictionary<string,int>();
    }
}
