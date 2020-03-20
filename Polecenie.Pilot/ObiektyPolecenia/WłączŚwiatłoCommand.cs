using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot
{
    //BLANKIET
    public class WłączŚwiatłoCommand : ICommand
    {
        private readonly Światło _światło;

        public WłączŚwiatłoCommand(Światło światło)
        {
            _światło = światło;
        }

        public void Execute()
        {
            _światło.Włącz();
        }

        public void Undo()
        {
            _światło.Wyłącz();
        }
    }
}
