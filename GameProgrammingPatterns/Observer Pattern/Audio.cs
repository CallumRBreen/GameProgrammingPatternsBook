using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns.Observer_Pattern
{
    class Audio : Observer
    {
        public override void onNotify(int pretendEventcode, int pretendEntity)
        {
            switch(pretendEventcode)
            {
                case 343:
                    // Do pretend stuff on entity after receiving notification from subject
                    pretendEntity = 5 + 5;
                    break;
                default:
                    pretendEntity = 9 * 5;
                    break;
            }
        }
    }
}
