using System;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WłączTVCommand : ICommand
    {
        private readonly TV _tv;

        public WłączTVCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Włącz();
        }

        public void Undo()
        {
            _tv.Wyłącz();
        }
    }
}
