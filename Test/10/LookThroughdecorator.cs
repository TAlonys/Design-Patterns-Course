using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    class LookThroughdecorator : BaseWindowDecorator
    {
        public LookThroughdecorator(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and look through";
        }
    }
}
