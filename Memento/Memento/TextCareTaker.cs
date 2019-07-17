using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> mementos= new List<TextMemento>();
        int currMemento = 0;

        public void AddMemento(TextMemento memento)
        {

            this.mementos.Add(memento);

            if (this.currMemento != this.mementos.Count - 1)
            {
                this.mementos.RemoveRange(this.currMemento, this.mementos.Count - this.currMemento);
                this.currMemento = this.mementos.Count - 1;
            }
            else
            {
                this.currMemento++;

            }
        }

        public TextMemento GetPreviouse()
        {
            if (this.currMemento > 0)
                this.currMemento--;
            else
                return null;

            return this.mementos[this.currMemento];
        }

        public TextMemento GetNext()
        {
            if (this.currMemento < this.mementos.Count - 1)
                this.currMemento++;
            else
                return null;

            return this.mementos[this.currMemento];
        }
    }
}
