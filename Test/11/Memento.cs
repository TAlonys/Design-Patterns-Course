using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Memento
    {
        private GameBoard state;

        public Memento(GameBoard state)
        {
            this.state = state;
        }

        public GameBoard getState()
        {
            return state;
        }
    }
}
