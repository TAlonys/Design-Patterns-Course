using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StartNumbrer : IFormula
    {

        double number;

        public StartNumbrer(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {

            return this.number.ToString();
        }

        public double GetResult()
        {
            return this.number;
        }
    }
}
