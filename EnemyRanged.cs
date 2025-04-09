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

        EnemyRanged enemyRanged1 = new EnemyRanged("enemyRanged1", 4, 6, 10);
        EnemyRanged enemyRanged2 = new EnemyRanged("enemyRanged1", 5, 7, 10);
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
            list.Add(enemyRanged1);
            list.Add(enemyRanged2);
        }
    }
}
