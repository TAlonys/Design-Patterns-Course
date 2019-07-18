using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test180719
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite(2);

            Component container1 = new Composite(2);
            Component circle2 = new Leaf(2);
            Component circle3 = new Leaf(8);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite(2);
            Component t1 = new Leaf(12);
            Component t2 = new Leaf(50);
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);


            Console.WriteLine("***********************");

            Console.WriteLine(root.SumLeaf());

            Console.WriteLine("***********************");

            Console.WriteLine(IsAllEven(root));
        }

        public static bool IsAllEven(Component root)
        {
            if (!root.IsEven()) return false;
            else if (root is Leaf) return true;

            foreach (Component c in root.GetChilds())
            {
                if (!IsAllEven(c)) return false;
            }

            return true;
        }
    }
}