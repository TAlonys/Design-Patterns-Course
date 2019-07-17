using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mul : CalcDecorator
    {
        public Mul(IFormula first, IFormula second) : base(first, second)
        {
        }

        public override string GetFormula()
        {
            return $"{this.FirstNumber.GetFormula()} * {this.SecondNumber.GetFormula()}";

        }

        public override double GetResult()
        {
            return (this.FirstNumber.GetResult() * this.SecondNumber.GetResult());
        }
    }
}
