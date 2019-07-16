using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebInfoPrototype
{
    class WebInfo : IPrototype<WebInfo>
    {
        public WebInfo(TimeSpan time, int size, string url)
        {
            Thread.Sleep(1000);
            Time = time;
            Size = size;
            Url = url;
        }

        TimeSpan Time { set; get; }
        int Size { set; get; }
        string Url { set; get; }

        public WebInfo Clone()
        {
            return new WebInfo(this.Time, this.Size, this.Url);
        }

        public override string ToString()
        {
            return this.Url + " Size: " + this.Size;
        }
    }
}
