using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class ZamknijDrzwiGarażoweCommand : ICommand
    {
        private readonly DrzwiGarażowe _drzwiGarażowe;

        public ZamknijDrzwiGarażoweCommand(DrzwiGarażowe drzwiGarażowe)
        {
            _drzwiGarażowe = drzwiGarażowe;
        }

        public void Execute()
        {
            _drzwiGarażowe.NaDół();
        }
    }
}
