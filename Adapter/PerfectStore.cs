using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PerfectStore : IDBData
    {
        public void Store(ClientData wcd)
        {
            Console.WriteLine($"Name: {wcd.name}, ID: {wcd.ID}");
        }
    }
}
