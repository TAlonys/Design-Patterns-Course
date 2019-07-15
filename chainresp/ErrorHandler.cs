using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChainResp
{
    public class ErrorHandler : LoggerHandler
    {
        public override void LogHandle(string msg, string LEVEL)
        {
            if (LEVEL == "Error")
            {
                Console.WriteLine($"Error: {msg}");
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
