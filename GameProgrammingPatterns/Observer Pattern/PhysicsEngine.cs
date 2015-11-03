using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Observer_Pattern
{
    class PhysicsEngine : Subject
    {
        public PhysicsEngine()
        {
            Audio audioObserver = new Audio();
            Achievements achievementObserver = new Achievements();

            AddObserver(audioObserver);
            AddObserver(achievementObserver);

            NotifyObservers(52, 34);
        }

    }
}
