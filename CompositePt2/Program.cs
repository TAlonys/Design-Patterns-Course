using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root");
            //Component circle1 = new Leaf("Circle 1");
            //Component rectangle = new Leaf("Rectangle x");
            //root.AddChild(circle1);
            //root.AddChild(rectangle);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 1");
            Component circle3 = new Leaf("Circle 2");
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles");
            Component t1 = new Leaf("Triangle 1");
            Component t2 = new Leaf("Triangle 2");
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            root.Draw("");

            Console.WriteLine("***********************");

            Console.WriteLine(root.CountLeaf());


            Console.WriteLine("***********************");

            if(IsFull(root))
            {
                Console.WriteLine("FULL");
            }
            else
            {
                Console.WriteLine("NOT FULL");
            }
        }

        public static bool IsFull(Component root)
        {
            bool left;
            bool right;
            bool result = true;

            if (root is Composite)
            {
                if (root.GetChilds().Count != 2 && root.GetChilds().Count != 0)
                {
                    result = false;
                }
                else if (root.GetChilds()[0] != null)
                {
                    left = IsFull(root.GetChilds()[0]);
                    right = IsFull(root.GetChilds()[1]);

                    result = right && left;
                }
            }

            return result;
        }
    }
}
