using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Player
    {
        public int life;
        public int damage;

        public int Life { get { return life; } }
        public int Damage { get { return damage; } }

        public Player(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }
        
    }
}
