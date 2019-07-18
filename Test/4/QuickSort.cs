using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuickSort : ISort
    {
        public void Sort(IList<int> listToSort)
        {
            Console.WriteLine("QuickSort");
        }
    }
}
