using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Observer_Pattern
{
    abstract class Observer
    {
        public abstract void onNotify(int pretendEventcode, int pretendEntity);
    }
}
