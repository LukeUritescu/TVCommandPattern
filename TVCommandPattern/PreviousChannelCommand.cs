using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern
{
    public class PreviousChannelCommand : Commands.Command
    {
        public PreviousChannelCommand(CommandWithUndo command)
        {
            this.CommandName = "Previous Channel " + command.CommandName;
        }
    }
}
