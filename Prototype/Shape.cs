using ProtoType;

namespace Prototype 
{
    public class Shape : IProtoType<Shape>
    {
        public virtual Shape clone()
        {
            return null;
        }
    }
}