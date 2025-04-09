using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    abstract class Enemy
    {
        public int ammo;
        public bool live;
        protected string name;
        public int life;
        public int damage;
        public Enemy(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }
        public abstract bool Live();
        public abstract int Life();
        public abstract int Damage();

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLife(int life)
        {
            this.life = life;
        }
        public void SetDamage(int damage)
        {
            this.damage = damage;
        }

        public string GetData()
        {
            return $"{name}: {Live()}, {Damage()}";
        }
        public abstract void AddEnemiesToList();
        
    }
}
