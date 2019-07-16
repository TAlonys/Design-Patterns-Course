using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class BadStore : IDBWebData
    {
        public void Store(WebClientData wcd)
        {
            Console.WriteLine($"Name: {wcd.name}, ID: {wcd.ID}, IP: {wcd.IP}, SSL: {wcd.SSL}");
        }
    }
}
