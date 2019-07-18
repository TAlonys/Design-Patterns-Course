using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseHandler infoLogger = new Info();
            BaseHandler errorLogger = new ErrorLog();
            BaseHandler fatalLogger = new FatalLog();

            infoLogger.Next = errorLogger;
            errorLogger.Next = fatalLogger;

            infoLogger.Handle("Ravid", 1);
            Console.WriteLine();
            Console.WriteLine();

            infoLogger.Handle("Ravid", 2);
            Console.WriteLine();
            Console.WriteLine();

            infoLogger.Handle("Ravid", 3);
        }
    }
}
