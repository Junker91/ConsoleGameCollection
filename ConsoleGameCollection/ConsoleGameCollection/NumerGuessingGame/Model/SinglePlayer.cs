using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection.NumerGuessingGame.Model {
    public class SinglePlayer {
        private Player _player;
        private int _minimunValue;
        private int _maximunValue;

        public SinglePlayer(Player player, int minimunValue, int maximunValue) {
            this._player = player;
            this._minimunValue = minimunValue;
            this._maximunValue = maximunValue;
        }
    }
}
