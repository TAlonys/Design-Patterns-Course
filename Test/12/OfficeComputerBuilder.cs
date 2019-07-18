using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OfficeComputerBuilder : ComputerBuilder
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
            computer.AddProcessor("Regular Processor");
        }

        protected override void AddGraphicCard()
        {
            computer.AddProcessor("Regular graphic card");
        }

        protected override void AddMemmory()
        {
            computer.AddMemmory("Regular memmory");
        }
    }
}
