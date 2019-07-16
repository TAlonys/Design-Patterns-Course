using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Shop : IVisitable
    {
        public double price;
        public int area = 50;

        public Shop(double price)
        {
            this.price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"shop price : {price}";
        }
    }
}
