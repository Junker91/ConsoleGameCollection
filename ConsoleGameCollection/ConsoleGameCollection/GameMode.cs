﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection {
    public class GameMode {
        
        private Dictionary<string, Player> playerDic = new Dictionary<string, Player>();

        public abstract void NextTurn();
    }
}