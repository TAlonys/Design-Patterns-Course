using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerHandler debug = new DebugHandler();
            LoggerHandler info = new InfoHandler();
            LoggerHandler error = new ErrorHandler();
            LoggerHandler fatal = new FatalHandler();

            debug.Next = info;
            info.Next = error;
            error.Next = fatal;

            debug.LogHandle("Tomer is trying to log info", "Info");
            debug.LogHandle("Tomer is trying to log debug", "Debug");
            debug.LogHandle("Tomer is trying to log fatal", "Fatal");
            debug.LogHandle("Tomer is trying to log error", "Error");
        }
    }
}
