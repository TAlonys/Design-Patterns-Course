using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class DemagedSpaceShipState : IGameState
    {
        public DemagedSpaceShipState(int level, int life)
        {
            this.level = level;
            this.life = life;
        }

        public override IGameState GetHit()
        {
            if (this.life == 1)
            {
                return new LoseState(this.level);
            }

            return new DemagedSpaceShipState(this.level, life - 1);
        }

        public override IGameState PassLevel()
        {
            if (this.level == 1)
            {
                return new WinState(this.life);
            }

            return new DemagedSpaceShipState(this.level - 1, life);
        }
    }
}
