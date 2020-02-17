using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern
{
    interface ICommandWithUndo : ICommand
    {
        PreviousChannelCommand PreviousChannelCommand { get; set; }
    }
}
