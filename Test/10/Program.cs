using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow window = new FrameDecorator(new ShadowDecorator(new LightDecorator(new BaseWindow())));
            Console.WriteLine(window.PrintWindow());

            IWindow window2 = new LookThroughdecorator(window);
            Console.WriteLine(window2.PrintWindow());
        }
    }
}
