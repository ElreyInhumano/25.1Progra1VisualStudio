using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class EnemyRanged : Enemy
    {
        private int ammo;
        public EnemyRanged(string name, int life, int damage, int ammo):base(name, life, damage)
        {
            this.ammo = ammo;
        }
        public override bool Live()
        {
            return Live();
        }
        public override int Damage()
        {
            return Damage();
        }
        public override int Life()
        {
            return Life();
        }
    }
}
