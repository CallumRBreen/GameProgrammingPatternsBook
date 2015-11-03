using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    class Enemy : Actor
    {
        public Enemy(string enemyName)
        {
            name = enemyName;
        }

        public override void Shoot()
        {
            Console.WriteLine(name + " shoots with a mega laser!");
        }
    }
}
