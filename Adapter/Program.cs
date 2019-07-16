using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClientData data = new WebClientData("Tomer", "12312", "125.12.4.1", true);

            storeData(new AdapterIDBWebDataToClientData(), data);
        }

        // non mutable
        private static void storeData(IDBWebData webData, WebClientData wcd)
        {
            webData.Store(wcd);
        }
    }
}