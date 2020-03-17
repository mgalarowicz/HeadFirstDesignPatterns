using System;
using Polecenie.Pilot.ObiektyPolecenia;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot
{
    //KLIENT
    class Program
    {
        static void Main(string[] args)
        {
            MiniPilot pilot = new MiniPilot();
            
            Światło światło = new Światło();
            DrzwiGarażowe drzwiGarażowe = new DrzwiGarażowe();
            
            WłączŚwiatłoCommand włączŚwiatło = new WłączŚwiatłoCommand(światło);
            OtwórzDrzwiGarażoweCommand otwórzDrzwiGarażowe = new OtwórzDrzwiGarażoweCommand(drzwiGarażowe);

            pilot.UstawPolecenie(włączŚwiatło);
            pilot.PrzyciskZostałWciśnięty();

            pilot.UstawPolecenie(otwórzDrzwiGarażowe);
            pilot.PrzyciskZostałWciśnięty();
        }
    }
}
