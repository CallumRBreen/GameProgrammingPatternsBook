using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Prototype_Pattern
{
    class Spawner
    {
        private Monster _prototype;

        public Spawner(Monster prototype)
        {
            _prototype = prototype;
        }

        public Monster SpawnMonster()
        {
            return _prototype.clone();
        }
    }
}
