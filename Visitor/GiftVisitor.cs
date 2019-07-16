using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class GiftVisitor : IVisitor
    {
        public double Visit(Liquor liquor)
        {
            return 1;
        }

        public double Visit(Tabacco tabacco)
        {
            return 1;
        }

        public double Visit(Chocolate chocolate)
        {
            return 1;
        }

        public double Visit(SomeProduct chocolate)
        {
            return 1;
        }

        public double Visit(Shop shop)
        {
            return 10;
        }
    }
}
