using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern
{
    interface ICommand
    {
        void Execute(TV go);
    }
}
