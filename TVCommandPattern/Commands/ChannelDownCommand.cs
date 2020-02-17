using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern.Commands
{
    class ChannelDownCommand : Commands.Command
    {
        public ChannelDownCommand()
        {
            this.CommandName = "Channel Down";
        }

        public override void Execute(TV go)
        {
            go.ChannelDown();
            base.Execute(go);
        }
    }

    ///Wanted to implement a Previous channel similar to to an Undo button


    //public class UndoChannelDownCommand : PreviousChannelCommand
    //{
    //    public UndoChannelDownCommand(CommandWithUndo command) : base(command)
    //    {

    //    }

    //    public override void Execute(TV go)
    //    {
    //        go.PreviousChannel();
    //        base.Execute(go);
    //    }

    //}

}
