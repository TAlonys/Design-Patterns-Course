using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock a = Clock.GetInstance();
            Clock b = Clock.GetInstance();
            Clock c = Clock.GetInstance();

            Console.WriteLine(a.GetTime());
            Console.WriteLine(b.GetTime());
            Console.WriteLine(c.GetTime());
        }
    }
}
