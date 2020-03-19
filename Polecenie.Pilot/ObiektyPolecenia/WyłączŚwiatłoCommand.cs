using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WyłączŚwiatłoCommand : ICommand
    {
        private readonly Światło _światło;

        public WyłączŚwiatłoCommand(Światło światło)
        {
            _światło = światło;
        }

        public void Execute()
        {
            _światło.Wyłącz();
        }
    }
}
