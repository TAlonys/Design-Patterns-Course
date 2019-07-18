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
            NumberCollection nc = new NumberCollection();
            nc.Add(1);
            nc.Add(2);
            nc.Add(3);
            nc.Add(4);
            nc.Add(5);
            nc.Add(6);
            nc.Add(7);
            nc.Add(8);
            nc.Add(9);

            nc.Sort();

            nc.Add(10);
            nc.Add(11);
            nc.Sort();
        }
    }
}
