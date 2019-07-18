using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        protected override void BuildPackage()
        {
            computer.BuildPackage("Regular package");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("Regular mother board");
        }

        protected override void AddProcessor()
        {
            computer.AddProcessor("Strong Processor");
        }

        protected override void AddGraphicCard()
        {
            computer.AddProcessor("Strong graphic card");
        }

        protected override void AddMemmory()
        {
            computer.AddMemmory("A lot of memmory");
        }
    }
}
