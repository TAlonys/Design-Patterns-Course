using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test180719
{
    public class Composite : Component
    {
        IList<Component> childs = new List<Component>();

        public Composite(int number) : base(number)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override int SumLeaf()
        {
            int sum = this.nodeValue;

            foreach (Component c in childs)
            {
                sum += c.SumLeaf();
            }

            return sum;
        }
    }
}