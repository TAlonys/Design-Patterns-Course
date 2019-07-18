using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {

        private List<String> parts = new List<String>();

        
        public List<String> GetParts()
        {
            return this.parts;
        }

        public void BuildPackage(String package)
        {
            parts.Add(package);
        }

        public void AddMotherBoard(String motherBoard)
        {
            parts.Add(motherBoard);
        }

        public void AddProcessor(String processor)
        {
            parts.Add(processor);
        }

        public void AddGraphicCard(String graphicCard)
        {
            parts.Add(graphicCard);
        }
        public void AddMemmory(String memmory)
        {
            parts.Add(memmory);
        }
    }
}
