using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class PrimitiveCarProxy
    {
        ICar car = new RealCar();

        public void ShowFuel()
        {
            car.ShowFuel();
        }

        public void ShowLocation()
        {
            car.ShowLocation();
        }
    }
}
