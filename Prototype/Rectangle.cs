using ProtoType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public Point topLeftCorner { get; set; }
        public Point topRightCorner { get; set; }
        public Point bottomLeftCorner { get; set; }
        public Point bottomRightCorner { get; set; }

        public Rectangle(Point topLeftCorner, Point topRightCorner, Point bottomLeftCorner, Point bottomRightCorner)
        {
            this.topLeftCorner = topLeftCorner;
            this.topRightCorner = topRightCorner;
            this.bottomLeftCorner = bottomLeftCorner;
            this.bottomRightCorner = bottomRightCorner;
        }

        public override string ToString()
        {
            return $"Rectangle points {topLeftCorner}, {topRightCorner}, {bottomLeftCorner}, {bottomRightCorner} \n";
        }

        public override Shape clone()
        {
            return new Rectangle(topLeftCorner.clone(), topRightCorner.clone(), bottomLeftCorner.clone(), bottomRightCorner.clone());
        }
    }
}
