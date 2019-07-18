using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class FineSpaceShipState : IGameState
    {
        public FineSpaceShipState(int level, int life)
        {
            this.level = level;
            this.life = life;
        }

        public override IGameState GetHit()
        {
            return new DemagedSpaceShipState(level, this.life - 1);
        }

        public override IGameState PassLevel()
        {
            this.level--;
            return new FineSpaceShipState(level, life);
        }
    }
}
