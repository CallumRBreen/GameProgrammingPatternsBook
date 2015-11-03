using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    static class InputHandler
    {
        public static Command HandleInput(string commandType)
        {
            switch(commandType)
            {
                case "Jump":
                    return new JumpCommand();
                case "Fire":
                    return new FireCommand();
                case "Dodge":
                    return new DodgeCommand();
                case "Duck":
                    return new DuckCommand();
                default:
                    return new DefaultCommand();
            }
        }     
    }
}
