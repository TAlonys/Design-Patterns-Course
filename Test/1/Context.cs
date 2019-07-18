using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Context
    {
        public IGameState state = new FineSpaceShipState(3, 3);

        public void GetHit()
        {
            if (state is WinState || state is LoseState)
            {
                Console.WriteLine("Game finished");
            }
            else
            {
                this.state = state.GetHit();
            }
        }

        public void PassLevel()
        {
            if (state is WinState || state is LoseState)
            {
                Console.WriteLine("Game finished");
            }
            else
            {
                this.state = state.PassLevel();
            }
        }
    }
}
