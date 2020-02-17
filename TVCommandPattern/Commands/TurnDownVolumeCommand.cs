using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class TurnDownVolumeCommand : Commands.Command
    {
        public TurnDownVolumeCommand()
        {
            this.CommandName = "Volume Up";
        }

        public override void Execute(TV go)
        {
            go.VolumeDown();
            base.Execute(go);
        }
    }
}
