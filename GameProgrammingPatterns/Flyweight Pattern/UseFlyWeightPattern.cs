using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    class UseFlyWeightPattern
    {
        public UseFlyWeightPattern()
        {
            List<Tree> trees = new List<Tree>();

            for(int i = 0; i < 1000; i++)
            {
                Tree newTree = new Tree();
            }
        }

    }
}
