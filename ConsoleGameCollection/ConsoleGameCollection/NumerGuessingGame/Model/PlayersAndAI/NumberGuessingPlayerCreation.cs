using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameCollection.NumerGuessingGame.Model;

namespace ConsoleGameCollection.NumerGuessingGame.Controller {
    class NumberGuessingPlayerCreation {
        private List<NumberGuessingPlayer> _playersList;

        public NumberGuessingPlayerCreation() {
            _playersList = new List<NumberGuessingPlayer>();
        }

        public List<NumberGuessingPlayer> GetPlayers() {
            return _playersList;
        }

        public void CreatePlayer(string name, int lives) {
            NumberGuessingPlayer player = new NumberGuessingPlayer();
            player.Name = name;
            player.Lives = lives;
            _playersList.Add(player);
        }
    }
}
