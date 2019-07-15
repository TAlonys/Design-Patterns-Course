using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    public class DebugHandler : LoggerHandler
    {
        public override void LogHandle(string msg, string LEVEL)
        {
            if (LEVEL == "Debug")
            {
                Console.WriteLine($"Debug: {msg}");
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
