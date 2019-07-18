using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            NumberCollection nc = new NumberCollection();
            nc.Add(1);
            nc.Add(2);
            nc.Add(3);
            nc.Add(4);
            nc.Add(5);
            nc.Add(-5);

            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Sort the array");
                Console.WriteLine("2 - Multiply the array by 2");
                Console.WriteLine("3 - Exit");
                option = Int32.Parse(Console.ReadLine());

                if (option == 1)
                {
                    nc.Sort();
                } else if (option == 2) {
                    nc.Multiply();
                }

                Console.WriteLine(nc.ToString());
            } while (option != 3);
        }
    }
}
