using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    class UseCommandPattern
    {
        public UseCommandPattern()
        {
            Actor A = new Player("Callum");

            Command genericCommand;

            genericCommand = InputHandler.HandleInput("Duck");
            genericCommand.execute(A);

            genericCommand = InputHandler.HandleInput("Fire");
            genericCommand.execute(A);

            genericCommand = InputHandler.HandleInput("");
            genericCommand.execute(A);

            Actor B = new Enemy("Mr. Evil");

            genericCommand = InputHandler.HandleInput("Duck");
            genericCommand.execute(B);

            genericCommand = InputHandler.HandleInput("Fire");
            genericCommand.execute(B);

            genericCommand = InputHandler.HandleInput("");
            genericCommand.execute(B);

        }
    }
}
