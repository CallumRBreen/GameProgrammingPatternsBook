using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Prototype_Pattern
{
    class Zombie : Monster
    {
        public override Monster clone()
        {
            return new Zombie();
        }
    }
}
