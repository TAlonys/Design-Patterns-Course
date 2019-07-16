using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebInfoPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            WebInfoFactory factory = new WebInfoFactory();

            Console.WriteLine(factory.Create("ravid"));
            Console.WriteLine(factory.Create("ravid"));
            Console.WriteLine(factory.Create("ravid2"));
            Console.WriteLine(factory.Create("ravid3"));
            Console.WriteLine(factory.Create("ravid2"));
        }
    }
}
