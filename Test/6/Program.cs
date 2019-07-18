using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory factory = new ObjectFactory();

            List<FlyWeightObject> list = new List<FlyWeightObject>();
            list.Add(new FlyWeightObject(2, 4));
            list.Add(new FlyWeightObject(100, 100));
            list.Add(new FlyWeightObject(100, 100));
            list.Add(new FlyWeightObject(100, 100));

            
            foreach(FlyWeightObject fly in list)
            {
                Console.WriteLine(factory.GetHeavyObject(fly).Value);
            }
        }
    }
}
