using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class FatalLog : BaseHandler
    {
        public override void Handle(string message, int logLevel)
        {
            if (logLevel > 2)
            {
                Console.WriteLine("written to SMS: " + message);
            }
        }
    }
}
