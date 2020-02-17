using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class TurnOffTVCommand : Commands.Command
    {
        public TurnOffTVCommand()
        {
            this.CommandName = "Tv OFF";
        }

        public override void Execute(TV go)
        {
            go.TvOFF();
            base.Execute(go);
        }
    }
}
