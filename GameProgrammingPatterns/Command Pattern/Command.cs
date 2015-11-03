using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingPatterns
{
    abstract class Command
    {
        abstract public void execute(Actor anyActor);
    }

    #region Custom Commands
    class JumpCommand : Command
    {
        public override void execute(Actor anyActor)
        {
            anyActor.Jump();
        }
    }

    class FireCommand : Command
    {
        public override void execute(Actor anyActor)
        {
            anyActor.Shoot();
        }
    }

    class DodgeCommand : Command
    {
        public override void execute(Actor anyActor)
        {
            anyActor.Dodge();
        }
    }

    class DuckCommand : Command
    {
        public override void execute(Actor anyActor)
        {
            anyActor.Duck();
        }
    }

    class DefaultCommand : Command
    {
        public override void execute(Actor anyActor)
        {
            anyActor.DoNothing();
        }
    }
    #endregion Custom Commands

}
