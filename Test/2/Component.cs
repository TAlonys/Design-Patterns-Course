using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test180719
{
    public abstract class Component
    {
        protected int nodeValue { set; get; }

        protected Component(int number)
        {
            this.nodeValue = number;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract int SumLeaf();

        public bool IsEven()
        {
            return this.nodeValue % 2 == 0;
        }
    }
}