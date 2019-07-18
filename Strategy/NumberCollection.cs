using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NumberCollection
    {
        public List<int> listOfNumbers { get; set; }
        private ISort sortStrategy { get; set; }

        public NumberCollection()
        {
            listOfNumbers = new List<int>();
        }

        public void Add(int number)
        {
            listOfNumbers.Add(number);

            if (listOfNumbers.Count > 10)
                sortStrategy = new MergeSort();
            else
                sortStrategy = new QuickSort();
        }

        public void Remove(int number)
        {
            if (listOfNumbers.Count > 10)
                sortStrategy = new MergeSort();
            else
                sortStrategy = new QuickSort();
        }

        public void Sort()
        {
            sortStrategy.Sort(listOfNumbers);
        }
    }
}
