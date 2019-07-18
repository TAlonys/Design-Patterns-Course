using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LivingRoomComputerBuilder : ComputerBuilder
    {
        protected override void BuildPackage()
        {
            computer.BuildPackage("Thin package");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("Extra thin mother board");
        }

        protected override void AddProcessor()
        {
            computer.AddProcessor("Regular Processor");
        }

        protected override void AddGraphicCard()
        {
            computer.AddProcessor("Strong graphic card");
        }

        protected override void AddMemmory()
        {
            computer.AddMemmory("Regular memmory");
        }
    }
}
