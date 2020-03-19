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
            SuperPilot pilot = new SuperPilot();

            Światło jadalniaŚwiatło = new Światło("Jadalnia");

            Światło kuchniaŚwiatło = new Światło("Kuchnia");

            WentylatorSufitowy wentylatorSufitowy = new WentylatorSufitowy("Jadalnia");

            DrzwiGarażowe drzwiGarażowe = new DrzwiGarażowe();

            WieżaStereo wieżaStereo = new WieżaStereo("Jadalnia");


            WłączŚwiatłoCommand jadalniaWłączŚwiatło = new WłączŚwiatłoCommand(jadalniaŚwiatło);
            WyłączŚwiatłoCommand jadalniaWyłączŚwiatło = new WyłączŚwiatłoCommand(jadalniaŚwiatło);
            
            WłączŚwiatłoCommand kuchniaWłączŚwiatło = new WłączŚwiatłoCommand(kuchniaŚwiatło);
            WyłączŚwiatłoCommand kuchniaWyłączŚwiatło = new WyłączŚwiatłoCommand(kuchniaŚwiatło);

            WłączWentylatorSufitowyCommand włączWentylatorSufitowy = new WłączWentylatorSufitowyCommand(wentylatorSufitowy);
            WyłączWentylatorSufitowyCommand wyłączWentylatorSufitowy = new WyłączWentylatorSufitowyCommand(wentylatorSufitowy);

            OtwórzDrzwiGarażoweCommand otwórzDrzwiGarażowe = new OtwórzDrzwiGarażoweCommand(drzwiGarażowe);
            ZamknijDrzwiGarażoweCommand zamknijDrzwiGarażowe = new ZamknijDrzwiGarażoweCommand(drzwiGarażowe);

            WieżaStereoWłączCDCommand wieżaStereoWłączCD = new WieżaStereoWłączCDCommand(wieżaStereo);
            WieżaStereoWyłączCommand wieżaStereoWyłącz = new WieżaStereoWyłączCommand(wieżaStereo);


            pilot.UstawPolecenie(0, jadalniaWłączŚwiatło, jadalniaWyłączŚwiatło);
            pilot.UstawPolecenie(1, kuchniaWłączŚwiatło, kuchniaWyłączŚwiatło);
            pilot.UstawPolecenie(2, włączWentylatorSufitowy, wyłączWentylatorSufitowy);
            pilot.UstawPolecenie(3, wieżaStereoWłączCD, wieżaStereoWyłącz);
            pilot.UstawPolecenie(4, otwórzDrzwiGarażowe, zamknijDrzwiGarażowe);

            Console.WriteLine(pilot);

            pilot.WciśniętoPrzyciskWłącz(0);
            pilot.WciśniętoPrzyciskWyłącz(0);
            pilot.WciśniętoPrzyciskWłącz(1);
            pilot.WciśniętoPrzyciskWyłącz(1);
            pilot.WciśniętoPrzyciskWłącz(2);
            pilot.WciśniętoPrzyciskWyłącz(2);
            pilot.WciśniętoPrzyciskWłącz(3);
            pilot.WciśniętoPrzyciskWyłącz(3);
            pilot.WciśniętoPrzyciskWłącz(4);
            pilot.WciśniętoPrzyciskWyłącz(4);

            //MiniPilot pilot = new MiniPilot();

            //Światło światło = new Światło();
            //DrzwiGarażowe drzwiGarażowe = new DrzwiGarażowe();

            //WłączŚwiatłoCommand włączŚwiatło = new WłączŚwiatłoCommand(światło);
            //OtwórzDrzwiGarażoweCommand otwórzDrzwiGarażowe = new OtwórzDrzwiGarażoweCommand(drzwiGarażowe);

            //pilot.UstawPolecenie(włączŚwiatło);
            //pilot.PrzyciskZostałWciśnięty();

            //pilot.UstawPolecenie(otwórzDrzwiGarażowe);
            //pilot.PrzyciskZostałWciśnięty();
        }
    }
}
