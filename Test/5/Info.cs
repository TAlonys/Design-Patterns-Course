using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Info : BaseHandler
    {
        public override void Handle(string message, int logLevel)
        {
            Console.WriteLine("Written to console: " + message);
            this.Next.Handle(message, logLevel);
        }
    }
}
