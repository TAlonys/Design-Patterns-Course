using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public abstract class BaseHandler
    {
        public BaseHandler Next { get; set; }

        public abstract void Handle(string message, int logLevel);
    }
}
