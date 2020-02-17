
using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
   public abstract class Command : ICommand
    {
        public string CommandName;

        public Command()
        {
            this.CommandName = "Base Command Name";
        }

        public virtual void Execute(TV go)
        {
            this.Log();
        }

        protected virtual void Log()
        {
            Console.WriteLine($"\n{this.CommandName} executed");
        }

        protected virtual void Log(TV go)
        {
            this.Log();
            Console.WriteLine("on " + go.ToString());
        }
    }
}
