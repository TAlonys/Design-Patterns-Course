using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class RealCar : ICar
    {
        public void Fast()
        {
            Console.WriteLine("Fast");
        }

        public void ShowFuel()
        {
            Console.WriteLine("Show fuel");
        }

        public void ShowLocation()
        {
            Console.WriteLine("ShowLocation");
        }

        public void Slow()
        {
            Console.WriteLine("Slow");
        }

        public void StartDriving()
        {
            Console.WriteLine("start driving");
        }

        public void StopDriving()
        {
            Console.WriteLine("stopdriving");
        }
    }
}
