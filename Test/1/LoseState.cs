using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class LoseState : IGameState
    {
        public LoseState(int level)
        {
            this.level = level;
            this.life = 0;
        }

        public override IGameState GetHit()
        {
            return this;
        }

        public override IGameState PassLevel()
        {
            return this;
        }
    }
}
