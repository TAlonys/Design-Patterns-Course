using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class SomeProduct : ProductBase, IVisitable
    {
        public SomeProduct(double price) : base(price)
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"SomeProduct price : {Price}";
        }
    }
}
