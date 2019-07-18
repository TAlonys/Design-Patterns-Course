using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class WinState : IGameState
    {
        public WinState(int life)
        {
            this.life = life;
            this.level = 0;
        }

        public override IGameState GetHit()
        {
            return new WinState(this.life);
        }

        public override IGameState PassLevel()
        {
            return new WinState(this.life);
        }
    }
}
