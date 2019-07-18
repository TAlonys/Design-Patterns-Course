using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class ObjectFactory
    {
        Dictionary<FlyWeightObject, HeavyObject> repository = new Dictionary<FlyWeightObject, HeavyObject>();

        public HeavyObject GetHeavyObject(FlyWeightObject key)
        {
            if (repository.TryGetValue(key, out HeavyObject heavyObj))
            {
                return heavyObj;
            }
            else
            {
                repository.Add(key, new HeavyObject(key));
                return repository[key];
            }
        }
    }
}
