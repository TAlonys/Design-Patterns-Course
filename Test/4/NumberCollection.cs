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
        public int countPositives { get; set; }
        public int countNegatives { get; set; }
        public double Avg { get; set; }

        private ISort sortStrategy { get; set; }
        private IMultiply mulStrategy { get; set; }

        public NumberCollection(List list)
        {
            listOfNumbers = new List<int>();
            mulStrategy = new MulBy2();
        }

        public NumberCollection()
        {
            this.listOfNumbers = new List<int>();
            this.mulStrategy = new MulBy2();
        }

        public void Add(int number)
        {
            listOfNumbers.Add(number);

            if (listOfNumbers.Count > 10)
                sortStrategy = new MergeSort();
            else
                sortStrategy = new QuickSort();
            doStats();
        }

        public void Multiply()
        {
            this.mulStrategy.Multiply(this.listOfNumbers);
            doStats();
        }

        public void Remove(int number)
        {
            if (listOfNumbers.Count > 4)
                sortStrategy = new MergeSort();
            else
                sortStrategy = new QuickSort();

            doStats();
        }

        private void doStats()
        {
            this.countNegatives = this.listOfNumbers.Where(number => number < 0).Count();
            this.countPositives = this.listOfNumbers.Where(number => number > 0).Count();
            this.Avg = listOfNumbers.Average(n => n);
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("=============================================");
            st.Append("Numbers: ");
            
            foreach (int n in listOfNumbers)
            {
                st.Append($"{n},");
            }

            st.AppendLine();
            st.AppendLine($"Number of numbers: {listOfNumbers.Count}");
            st.AppendLine($"Number of positive numbers: {this.countPositives}");
            st.AppendLine($"Number of negative numbers: {this.countNegatives}");
            st.AppendLine($"Average of numbers: {this.Avg}");
            st.Append("=============================================");

            return st.ToString();
        }

        public void Sort()
        {
            sortStrategy.Sort(listOfNumbers);
        }
    }
}
