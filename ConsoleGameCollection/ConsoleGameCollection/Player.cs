using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection {
    public abstract class Player {
        protected string name;
        protected int score;
        protected int lives;


        public virtual string Name {
            get {
                return name;
            }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("name string is null or empty");

                else
                    name = value;
                
            }
        }

        public abstract int Score { get; set; }

        public abstract int lives { get; set; }
    }
}
