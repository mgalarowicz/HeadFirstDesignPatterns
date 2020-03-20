using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
