using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class HeavyObject
    {
        public FlyWeightObject flyObject;
        
        public double Value;

        public HeavyObject(FlyWeightObject flyObject)
        {
            this.flyObject = flyObject;
            this.Value = Math.Pow(flyObject.Base, flyObject.Power);
        }
    }
}
