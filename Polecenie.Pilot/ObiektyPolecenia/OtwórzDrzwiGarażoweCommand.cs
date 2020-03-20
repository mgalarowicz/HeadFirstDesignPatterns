using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class OtwórzDrzwiGarażoweCommand : ICommand
    {
        private readonly DrzwiGarażowe _drzwiGarażowe;

        public OtwórzDrzwiGarażoweCommand(DrzwiGarażowe drzwiGarażowe)
        {
            _drzwiGarażowe = drzwiGarażowe;
        }

        public void Execute()
        {
            _drzwiGarażowe.DoGóry();
        }

        public void Undo() { }
    }
}
