using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Game
    {
        public Enemy enemyRanged1 = new EnemyRanged("enemigo2", 4, 6, 10);
        public Enemy enemyRanged2 = new EnemyRanged("enemigo4", 5, 7, 15);

        public Enemy enemyMelee1 = new EnemyMelee("enemigo1", 5, 3);
        public Enemy enemyMelee2 = new EnemyMelee("enemigo3", 6, 4);
        public Enemy enemyMelee3 = new EnemyMelee("enemigo5", 7, 5);

        public List<Enemy> list = new List<Enemy>();

        private static int life;
        private static int damage;
        Player player = new Player(life, damage);

        public void StartGame()
        {
            AddEnemiesToList();
            CreatePlayer();
            if(player.life > 0)
            {
                Fighting();
            }
            if (player.life <= 0)
            {
                Defeat();
            }
            if(list.Count <= 0)
            {
                Victory();
            }
        }

        public void Fighting()
        {
            bool attack = false;
            if(player.life > 0)
            {
                while (enemyMelee1.life > 0 && player.life > 0)
                {
                    attack = false;
                    Console.WriteLine($"Te enfrentas al primer enemigo este es de cuerpo a cuerpo {ShowInfoEnemy1()}");
                    while (!attack && player.life > 0)
                    {
                        Console.WriteLine("Es tu turno, ¿Lo atacas? (Escribir *si* para atacar)");
                        string yes = Console.ReadLine();
                        if (yes == "si")
                        {
                            enemyMelee1.life -= player.damage;
                            attack = true;
                        }
                    }
                    if (enemyMelee1.life <= 0)
                    {
                        Console.WriteLine("Enemigo eliminado");
                        list.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine($"Es el turno del enemigo y este te ataca");
                        player.life -= enemyMelee1.damage;
                        Console.WriteLine($"Te queda {player.life} de vida");
                    }
                }
                while (enemyRanged1.life > 0 && enemyMelee1.life <= 0 && player.life > 0)
                {
                    attack = false;
                    Console.WriteLine($"Te enfrentas al segundo enemigo este es de rango {ShowInfoEnemy2()}");
                    Console.WriteLine($"Es el turno del enemigo y este te ataca");
                    if (enemyRanged1.ammo > 0)
                    {
                        player.life -= enemyRanged1.damage;
                        enemyRanged1.ammo -= 5;
                        Console.WriteLine($"Te queda {player.life} de vida");
                    }
                    else if(enemyRanged1.ammo <= 0)
                    {
                        Console.WriteLine("El enemigo no tiene munición, por lo que pierde el turno recargando");
                        enemyRanged1.ammo += 10;
                    }
                    while (!attack && player.life > 0)
                    {
                        Console.WriteLine("Es tu turno, ¿Lo atacas? (Escribir *si* para atacar)");
                        string yes = Console.ReadLine();
                        if (yes == "si")
                        {
                            enemyRanged1.life -= player.damage;
                            attack = true;
                        }
                    }
                    if (enemyRanged1.life <= 0)
                    {
                        Console.WriteLine("Enemigo eliminado");
                        list.RemoveAt(0);
                    }
                }
                while (enemyMelee2.life > 0 && enemyMelee1.life <= 0 && enemyRanged1.life <= 0 && player.life > 0)
                {
                    attack = false;
                    Console.WriteLine($"Te enfrentas al tercer enemigo este es de cuerpo a cuerpo {ShowInfoEnemy3()}");
                    Console.WriteLine($"Es el turno del enemigo y este te ataca");
                    player.life -= enemyMelee2.damage;
                    Console.WriteLine($"Te queda {player.life} de vida");
                    while (!attack)
                    {
                        Console.WriteLine("Es tu turno, ¿Lo atacas? (Escribir *si* para atacar)");
                        string yes = Console.ReadLine();
                        if (yes == "si")
                        {
                            enemyMelee2.life -= player.damage;
                            attack = true;
                        }
                    }
                    if (enemyMelee2.life <= 0 && player.life > 0)
                    {
                        Console.WriteLine("Enemigo eliminado");
                        list.RemoveAt(0);
                    }
                }
                while (enemyRanged2.life > 0 && enemyMelee1.life <= 0 && enemyRanged1.life <= 0 && enemyMelee2.life <= 0 && player.life > 0)
                {
                    attack = false;
                    Console.WriteLine($"Te enfrentas al cuarto enemigo este es de rango {ShowInfoEnemy4()}");
                    Console.WriteLine($"Es el turno del enemigo y este te ataca");
                    if (enemyRanged2.ammo > 0)
                    {
                        player.life -= enemyRanged2.damage;
                        enemyRanged2.ammo -= 5;
                        Console.WriteLine($"Te queda {player.life} de vida");
                    }
                    else if (enemyRanged2.ammo <= 0)
                    {
                        Console.WriteLine("El enemigo no tiene munición, por lo que pierde el turno recargando");
                        enemyRanged2.ammo += 10;
                    }
                    while (!attack && player.life > 0)
                    {
                        Console.WriteLine("Es tu turno, ¿Lo atacas? (Escribir *si* para atacar)");
                        string yes = Console.ReadLine();
                        if (yes == "si")
                        {
                            enemyRanged2.life -= player.damage;
                            attack = true;
                        }
                    }
                    if (enemyRanged2.life <= 0)
                    {
                        Console.WriteLine("Enemigo eliminado");
                        list.RemoveAt(0);
                    }
                }
                while (enemyMelee3.life > 0 && enemyMelee1.life <= 0 && enemyRanged1.life <= 0
                    && enemyMelee2.life <= 0 && enemyRanged2.life <= 0 && player.life > 0)
                {
                    attack = false;
                    Console.WriteLine($"Te enfrentas al quinto enemigo este es de cuerpo a cuerpo {ShowInfoEnemy5()}");
                    Console.WriteLine($"Es el turno del enemigo y este te ataca");
                    player.life -= enemyMelee3.damage;
                    Console.WriteLine($"Te queda {player.life} de vida");
                    while (!attack && player.life > 0)
                    {
                        Console.WriteLine("Es tu turno, ¿Lo atacas? (Escribir *si* para atacar)");
                        string yes = Console.ReadLine();
                        if (yes == "si")
                        {
                            enemyMelee3.life -= player.damage;
                            attack = true;
                        }
                    }
                    if (enemyMelee3.life <= 0)
                    {
                        Console.WriteLine("Enemigo eliminado");
                        list.RemoveAt(0);
                    }
                }
            }
        }

        public void CreatePlayer()
        {
            bool pjCreated = false;
            while (!pjCreated)
            {
                Console.WriteLine("Introduzca la vida de su personaje");
                player.life = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el daño de su personaje");
                player.damage = int.Parse(Console.ReadLine());
                if (player.life + player.damage <= 100 && player.life + player.damage > 0 && player.life > 0 && player.damage > 0)
                {
                    Console.WriteLine($"Tu personaje tiene {player.life} de vida y {player.damage} de daño");
                    pjCreated = true;
                }
                else
                {
                    Console.WriteLine("Las estadísticas de tu personaje no pueden ser menor a cero o la suma de estas mayor a 100");
                }
            }
        }
        public void Defeat()
        {
            Console.WriteLine("Perdiste");
            Console.ReadLine();
        }

        public void Victory()
        {
            Console.WriteLine("Felicidades ganaste el juego");
            Console.ReadLine();
        }
        public void AddEnemiesToList()
        {
            list.Add(enemyRanged1);
            list.Add(enemyRanged2);
            list.Add(enemyMelee1);
            list.Add(enemyMelee2);
            list.Add(enemyMelee3);
        }
        public string ShowInfoEnemy2()
        {
            return $"tiene {enemyRanged1.life} de vida y {enemyRanged1.damage} de daño";
        }
        public string ShowInfoEnemy4()
        {
            return $"tiene {enemyRanged2.life} de vida y {enemyRanged2.damage} de daño";
        }
        public string ShowInfoEnemy1()
        {
            return $"tiene {enemyMelee1.life} de vida y {enemyMelee1.damage} de daño";
        }
        public string ShowInfoEnemy3()
        {
            return $"tiene {enemyMelee2.life} de vida y {enemyMelee2.damage} de daño";
        }
        public string ShowInfoEnemy5()
        {
            return $"tiene {enemyMelee3.life} de vida y {enemyMelee3.damage} de daño";
        }
    }
}
