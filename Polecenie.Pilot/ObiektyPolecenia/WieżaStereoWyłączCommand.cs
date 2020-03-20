using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WieżaStereoWyłączCommand : ICommand
    {
        private readonly WieżaStereo _wieżaStereo;

        public WieżaStereoWyłączCommand(WieżaStereo wieżaStereo)
        {
            _wieżaStereo = wieżaStereo;
        }

        public void Execute()
        {
            _wieżaStereo.Wyłącz();
        }

        public void Undo() { }
    }
}
