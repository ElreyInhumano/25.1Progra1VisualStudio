using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class EnemyMelee : Enemy
    {
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
            
        }

       
    }
}
