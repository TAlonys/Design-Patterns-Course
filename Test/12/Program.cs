using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();

            Computer gamingComputer = gamingComputerBuilder.GetComputer();


            OfficeComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();

            Computer officeComputer = officeComputerBuilder.GetComputer();


            LivingRoomComputerBuilder livingRoomComputerBuilder = new LivingRoomComputerBuilder();

            Computer livingRoomComputer = livingRoomComputerBuilder.GetComputer();

            PrintComputerParts(gamingComputer);
            PrintComputerParts(officeComputer);
            PrintComputerParts(livingRoomComputer);


        }


        static void PrintComputerParts(Computer computer)
        {

            Console.WriteLine("Your computer parts:");

            foreach (string part in computer.GetParts())
            {
                Console.WriteLine(part);
            }

            Console.WriteLine();
        }
    }
}
