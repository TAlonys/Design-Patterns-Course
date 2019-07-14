using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Clock
    {
        private static Clock INSTANCE;
        private static Object lockobject = new object();

        private Clock()
        {
                
        }

        public static Clock GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (lockobject)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Clock();
                }
            }

            return INSTANCE;
        }

        public DateTime GetTime()
        {
            return (DateTime.Now);
        }
    }
}
