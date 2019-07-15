using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    public class InfoHandler : LoggerHandler
    {
        public override void LogHandle(string msg, string LEVEL)
        {
            if (LEVEL == "Info")
            {
                Console.WriteLine($"Info: {msg}");
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
