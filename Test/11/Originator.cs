using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Originator
    {
        private GameBoard state;

        public void setState(GameBoard state)
        {
            this.state = new GameBoard(state);
        }

        public GameBoard getState()
        {
            return state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            state = memento.getState();
        }
    }
}
