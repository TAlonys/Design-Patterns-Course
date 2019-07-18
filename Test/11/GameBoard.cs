using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class GameBoard
    {
        private int xNumLoc { get; set; }
        private int yNumLoc { get; set; }

        int[,] n = new int[5, 5] 
        { 
            { 0,0,0,0,0},
            { 0,0,0,0,0},
            { 0,0,1,0,0},
            { 0,0,0,0,0},
            { 0,0,0,0,0}
        };
        private GameBoard state;

        public GameBoard()
        {
            xNumLoc = 2;
            yNumLoc = 2;
        }

        public GameBoard(GameBoard gb)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    n[i, j] = gb.n[i, j];
                }
            }

            xNumLoc = gb.xNumLoc;
            yNumLoc = gb.yNumLoc;
        }

        public bool Move(string direction)
        {
            bool didMakeIlegalMove = false;
            int value = n[yNumLoc, xNumLoc];
            n[yNumLoc, xNumLoc] = 0;

            switch (direction)
            {
                case "1": // up
                    if (yNumLoc - 1 < 0)
                    {
                        didMakeIlegalMove = true;
                    }
                    else
                    {
                        yNumLoc--;
                    }
                    break;
                case "2": // down
                    if (yNumLoc + 1 > 4)
                    {
                        didMakeIlegalMove = true;
                    }
                    else
                    {
                        yNumLoc++;
                    }

                    break;

                case "3": // right
                    if (xNumLoc + 1 > 4)
                    {
                        didMakeIlegalMove = true;
                    }
                    else
                    {
                        xNumLoc++;
                    }

                    break;

                case "4": // left
                    if (xNumLoc - 1 < 0)
                    {
                        didMakeIlegalMove = true;
                    }
                    else
                    {
                        xNumLoc--;
                    }
                    break;
                case "+":
                    if (value < 9) value++;
                    break;
                case "-":
                    if (value > 0) value--;
                    break;
                default:
                    {
                        break;
                    }
            }

            n[yNumLoc, xNumLoc] = value;
            return didMakeIlegalMove;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("===============");

            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    st.Append(n[i, j]);
                }

                st.AppendLine();
            }

            st.AppendLine("===============");

            return st.ToString();
        }
    }
}
