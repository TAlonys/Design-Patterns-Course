using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    class LightDecorator : BaseWindowDecorator
    {
        public LightDecorator(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and light";
        }
    }
}
