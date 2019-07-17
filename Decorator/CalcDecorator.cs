using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CalcDecorator : IFormula
    {

        protected IFormula FirstNumber;
        protected IFormula SecondNumber;

        public CalcDecorator(IFormula first, IFormula second)
        {
            this.FirstNumber = first;
            this.SecondNumber = second;
        }


        public abstract string GetFormula();

        public abstract double GetResult();

    }
}
