using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class TurnUpVolumeCommand : Commands.Command
    {
        public TurnUpVolumeCommand()
        {
            this.CommandName = "Volume Up";
        }

        public override void Execute(TV go)
        {
            go.VolumeUp();
            base.Execute(go);
        }
    }
}
