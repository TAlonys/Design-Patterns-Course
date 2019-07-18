using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    class FrameDecorator : BaseWindowDecorator
    {
        public FrameDecorator(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and frame";
        }
    }
}
