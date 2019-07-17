using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula formula = new Add(new Mul(new Sub(new Div(new Add(new Mul(new StartNumbrer(5), new StartNumbrer(2)), new StartNumbrer(100)), new StartNumbrer(12)), new StartNumbrer(3)), new StartNumbrer(4)), new StartNumbrer(7));

            Console.WriteLine(formula.GetResult());
            Console.WriteLine(formula.GetFormula());
        }
    }
}
