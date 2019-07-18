using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class ErrorLog : BaseHandler
    {
        public override void Handle(string message, int logLevel)
        {
            if (logLevel > 1)
            {
                Console.WriteLine("Written to file: " + message);
                this.Next.Handle(message, logLevel);
            }
        }
    }
}
