using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Player
    {
        private int life;
        private int damage;

        public int Life { get { return life; } }
        public int Damage { get { return damage; } }

        public Player(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }

        public void CreatePlayer()
        {
            Player player = new Player(life, damage);
            bool pjCreated = false;
            while (!pjCreated)
            {
                Console.WriteLine("Introduzca la vida de su personaje");
                player.life = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el daño de su personaje");
                player.damage = int.Parse(Console.ReadLine());
                if(player.life + player.damage <= 100 && player.life + player.damage > 0 && player.life > 0 && player.damage > 0)
                {
                    Console.WriteLine($"Tu personaje tiene{player.life} de vida y {player.damage} de daño");
                    pjCreated = true;
                }
                else
                {
                    Console.WriteLine("Las estadísticas de tu personaje no pueden ser menor a cero o la suma de estas mayor a 100");
                }
            }
        }
    }
}
