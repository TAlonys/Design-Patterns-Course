using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento getLast()
        {
            return mementoList[mementoList.Count - 1];
        }

        public bool isEmpty()
        {
            return mementoList.Count > 0;
        }
    }
}
