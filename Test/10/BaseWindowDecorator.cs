using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    public abstract class BaseWindowDecorator : IWindow
    {
        public IWindow Window { get; set; }
        public BaseWindowDecorator(IWindow window)
        {
            this.Window = window;
        }

        public abstract string PrintWindow();
    }
}
