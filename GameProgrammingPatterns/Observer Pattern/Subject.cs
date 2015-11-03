using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Observer_Pattern
{
    class Subject
    {
        List<Observer> observers = new List<Observer>(); //Pretend pointers to code

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int pretendEventcode, int pretendEntity)
        {
            foreach(Observer singleObserver in observers)
            {
                singleObserver.onNotify(pretendEventcode, pretendEntity);
            }
        }
    }
}
