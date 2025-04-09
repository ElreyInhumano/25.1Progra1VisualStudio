using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class EnemyRanged : Enemy
    {
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
        public override void AddEnemiesToList()
        {

        }
    }
}
