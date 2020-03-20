using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class EmptyCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}
