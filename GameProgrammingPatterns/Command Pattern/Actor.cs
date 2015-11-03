using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    abstract class Actor
    {
        public string name;

        public virtual void Jump()
        {
            Console.WriteLine(name + " jumps!");
        }

        public virtual void Shoot()
        {
            Console.WriteLine(name + " shoots!");
        }

        public virtual void Duck()
        {
            Console.WriteLine(name + " ducks!");
        }

        public virtual void Dodge()
        {
            Console.WriteLine(name + " dodges!");
        }

        public virtual void DoNothing()
        {
            Console.WriteLine(name + " does absolutely nothing!");
        }
    }
}
