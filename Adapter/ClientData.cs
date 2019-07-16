using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        public ClientData(string iD, string name)
        {
            ID = iD;
            this.name = name;
        }

        public string name { get; set; }
        public string ID { get; set; }
    }
}
