using ProtoType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ShapeHolder : IProtoType<ShapeHolder>
    {
        public List<Shape> listOfShapes { get; set; }

        public ShapeHolder()
        {
            listOfShapes = new List<Shape>();
        }

        public ShapeHolder(List<Shape> newList)
        {
            listOfShapes = newList;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            foreach (Shape item in listOfShapes)
            {
                st.Append(item.ToString());
                st.Append("\n");
            }

            return st.ToString();
        }

        public ShapeHolder clone()
        {
            List<Shape> newList = new List<Shape>();

            foreach (Shape item in listOfShapes)
            {
                newList.Add(item.clone());
            }

            return new ShapeHolder(newList);
        }
    }
}
