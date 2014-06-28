using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection {
    public abstract class GameMode {
        /* Contains all the variables that all game modes have in common 
         */

        private Dictionary<string, Player> playerDic = new Dictionary<string, Player>();
    }
}
