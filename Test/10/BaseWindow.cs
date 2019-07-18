using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowDecorator
{
    class BaseWindow : IWindow
    {
        public string PrintWindow()
        {
            return "Window";
        }
    }
}
