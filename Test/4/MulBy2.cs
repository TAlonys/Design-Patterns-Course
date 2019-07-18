using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MulBy2 : IMultiply
    {
        public void Multiply(IList<int> listToMul)
        {
            for (int i = 0; i < listToMul.Count; i++)
            {
                listToMul[i] *= 2;
            }
        }
    }
}
