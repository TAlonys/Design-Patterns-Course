using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    public abstract class IGameState
    {
        public int life;
        public int level;
        public abstract IGameState GetHit();

        public abstract IGameState PassLevel();

        public override string ToString()
        {
            return "life: " + this.life + " level: " + this.level;
        }
    }
}
