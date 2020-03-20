using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WieżaStereoWłączCDCommand : ICommand
    {
        private readonly WieżaStereo _wieżaStereo;

        public WieżaStereoWłączCDCommand(WieżaStereo wieżaStereo)
        {
            _wieżaStereo = wieżaStereo;
        }

        public void Execute()
        {
            _wieżaStereo.Włącz();
            _wieżaStereo.UstawCD();
            _wieżaStereo.UstawGłośność(11);
        }

        public void Undo() { }
    }
}
