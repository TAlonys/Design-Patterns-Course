using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyWeightObject
    {
        public FlyWeightObject(int @base, int power)
        {
            Base = @base;
            Power = power;
        }

        public int Base { get; set; }
        public int Power { get; set; }
    }
}
