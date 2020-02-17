using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class TurnOnTvCommand : Commands.Command
    {
        public TurnOnTvCommand()
        {
            this.CommandName = "Tv ON";
        }

        public override void Execute(TV go)
        {
            go.TvON();
            base.Execute(go);
        }
    }
}
