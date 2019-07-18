using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                this.BuildComputer(); ;

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new Computer();
            BuildPackage();
            AddMotherBoard();
            AddProcessor();
            AddGraphicCard();
            AddMemmory();
        }

        protected abstract void BuildPackage();
        protected abstract void AddMotherBoard();
        protected abstract void AddProcessor();
        protected abstract void AddGraphicCard();
        protected abstract void AddMemmory();

    }
}
