using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    public class FatalHandler : LoggerHandler
    {
        public override void LogHandle(string msg, string LEVEL)
        {
            if (LEVEL == "Fatal")
            {
                Console.WriteLine($"Fatal: {msg}");
            }
            else
            {
                if (Next != null)
                {
                    Next.LogHandle(msg, LEVEL);
                }
            }
        }
    }
}
