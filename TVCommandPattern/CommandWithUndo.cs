using System;
using System.Collections.Generic;
using System.Text;
using TVCommandPattern.Commands;

namespace TVCommandPattern
{
    public class CommandWithUndo : Command, ICommandWithUndo
    {
        TV go;
        public PreviousChannelCommand PreviousChannelCommand { get; set; }

        public void Execute(TV go)
        {
            this.go = go;
            base.Execute(go);
        }

        public void Unexcute()
        {
            this.PreviousChannelCommand.Execute(go);
        }
    }
}
