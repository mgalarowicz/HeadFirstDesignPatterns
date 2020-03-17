using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot
{
    //KELNERKA
    public class MiniPilot
    {
        ICommand _slot;

        public void UstawPolecenie(ICommand polecenie)
        {
            _slot = polecenie;
        }

        public void PrzyciskZostałWciśnięty()
        {
            _slot.Execute();
        }
    }
}
