using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Prototype_Pattern
{
    class UsePrototypePattern
    {
        public UsePrototypePattern()
        {
            Monster ghost = new Ghost();
            Monster zombie = new Zombie();

            Spawner ghostSpawner = new Spawner(ghost);
            ghostSpawner.SpawnMonster();

            Spawner zombieSpawner = new Spawner(zombie);
            zombieSpawner.SpawnMonster();
        }
    }
}
