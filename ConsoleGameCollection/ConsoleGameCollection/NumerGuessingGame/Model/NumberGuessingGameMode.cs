using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {
    public abstract class NumberGuessingGameMode : GameMode {
        protected Dictionary<string, int> _correctValueDic;
    }
}
