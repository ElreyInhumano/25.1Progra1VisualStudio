using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class EnemyMelee : Enemy
    {
        

        EnemyMelee enemyMelee1 = new EnemyMelee("enemy1", 5, 3);
        EnemyMelee enemyMelee2 = new EnemyMelee("enemy2", 6, 4);
        EnemyMelee enemyMelee3 = new EnemyMelee("enemy3", 7, 5);

        
        public  EnemyMelee(string name, int life, int damage):base(name, life, damage)
        {
            
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
            list.Add(enemyMelee1);
            list.Add(enemyMelee2);
            list.Add(enemyMelee3);
        }
    }
}
