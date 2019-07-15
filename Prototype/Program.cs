using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            ShapeHolder sh = new ShapeHolder();
            sh.listOfShapes.Add(new Rectangle(new Point(1, 2), new Point(1, 2), new Point(1, 2), new Point(1, 2)));
            sh.listOfShapes.Add(new Rectangle(new Point(3,4 ), new Point(5,2), new Point(1, 2), new Point(7,7)));
            sh.listOfShapes.Add(new Circle(new Point(5, 1), 15));

            ShapeHolder aaaaa = sh.clone();
            aaaaa.listOfShapes[0] = new Circle(new Point(1, 0), 222);

            Console.WriteLine(sh.ToString());
            Console.WriteLine("--------");
            Console.WriteLine(aaaaa.ToString());
        }
    }
}