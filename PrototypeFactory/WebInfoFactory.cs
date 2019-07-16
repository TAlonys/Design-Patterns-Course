using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebInfoPrototype
{
    class WebInfoFactory
    {
        private Dictionary<string, WebInfo> webInfos = new Dictionary<string, WebInfo>();

        public WebInfo Create(string url)
        {
            WebInfo required;
            if(!webInfos.TryGetValue(url, out required))
            {
                this.webInfos.Add(url, new WebInfo(new TimeSpan(), 123, url));
            }

            return webInfos[url].Clone();
        }
    }
}
