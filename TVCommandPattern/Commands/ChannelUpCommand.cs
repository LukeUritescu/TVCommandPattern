using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class ChannelUpCommand : Commands.Command
    {
        public ChannelUpCommand()
        {
            this.CommandName = "Channel Up";
        }

        public override void Execute(TV go)
        {
            go.ChannelUp();
            base.Execute(go);
        }
    }

    ///Wanted to implement a Previous channel similar to to an Undo button
    
    //public class UndoChannelUpCommand : PreviousChannelCommand
    //{
    //    public UndoChannelUpCommand(CommandWithUndo command) : base(command)
    //    {

    //    }

    //    public override void Execute(TV go)
    //    {
    //        go.PreviousChannel();
    //        base.Execute(go);
    //    }

    //}
}
