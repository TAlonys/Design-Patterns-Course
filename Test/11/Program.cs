using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard gb = new GameBoard();
            Originator originator = new Originator();
            CareTaker ct = new CareTaker();

            string option;
            Console.WriteLine(gb);
            bool didDoIllegalMove = false;

            do
            {
                Console.WriteLine("Enter your choice: 1 - up, 2 - down, 3 - left, 4 - right");
                Console.WriteLine("'+' - inc, '-' - dec, s - save, l - realod to last save, x - to exit");
                option = Console.ReadLine();
                

                didDoIllegalMove = gb.Move(option);

                if (option.CompareTo("s") == 0)
                {
                    originator.setState(gb);
                    ct.add(originator.saveStateToMemento());
                }
                if (didDoIllegalMove || (option.CompareTo("l") == 0 && originator.getState() != null))
                {
                    originator.getStateFromMemento(ct.getLast());
                    gb = originator.getState();
                }

                Console.WriteLine(gb);
            } while (option.CompareTo("x") != 0 && !didDoIllegalMove);

            if (didDoIllegalMove) Console.WriteLine("You made to wrong move, be smarter next time");
        }
    }
}
