using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    abstract class Game
    {
        private EnemyMelee enemyMelee;
        private EnemyRanged enemyRanged;
        private Player player;
        public void StartGame()
        {
            enemyMelee.AddEnemiesToList();
            enemyRanged.AddEnemiesToList();
            player.CreatePlayer();
        }
    }
}
