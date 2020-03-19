using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WyłączWentylatorSufitowyCommand : ICommand
    {
        private readonly WentylatorSufitowy _wentylatorSufitowy;

        public WyłączWentylatorSufitowyCommand(WentylatorSufitowy wentylatorSufitowy)
        {
            _wentylatorSufitowy = wentylatorSufitowy;
        }

        public void Execute()
        {
            _wentylatorSufitowy.Wyłącz();
        }
    }
}
