using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    public abstract class LoggerHandler
    {
        public LoggerHandler Next { set; get; }

        public abstract void LogHandle(String msg, String LEVEL);
    }
}
