using System;
using Polecenie.Pilot.ObiektyPolecenia;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot
{
    //KLIENT
    public class Program
    {
        static void Main(string[] args)
        {

            SuperPilotZWycofaniem pilot = new SuperPilotZWycofaniem();

            WentylatorSufitowy wentylatorSufitowy = new WentylatorSufitowy("Jadalnia");
            Światło światłoJadalnia = new Światło("Jadalnia");

            WłączWentylatorSufitowyŚrednioCommand wentylatorSufitowyŚrednio = new WłączWentylatorSufitowyŚrednioCommand(wentylatorSufitowy);
            WłączWentylatorSufitowySzybkoCommand wentylatorSufitowySzybko = new WłączWentylatorSufitowySzybkoCommand(wentylatorSufitowy);
            WyłączWentylatorSufitowyCommand wyłączWentylatorSufitowy = new WyłączWentylatorSufitowyCommand(wentylatorSufitowy);
            WłączŚwiatłoCommand włączŚwiatło = new WłączŚwiatłoCommand(światłoJadalnia);
            WyłączŚwiatłoCommand wyłączŚwiatło = new WyłączŚwiatłoCommand(światłoJadalnia);

            pilot.UstawPolecenie(0, wentylatorSufitowyŚrednio, wyłączWentylatorSufitowy);
            pilot.UstawPolecenie(1, wentylatorSufitowySzybko, wyłączWentylatorSufitowy);
            pilot.UstawPolecenie(2, włączŚwiatło, wyłączŚwiatło);

            pilot.WciśniętoPrzyciskWłącz(0);
            pilot.WciśniętoPrzyciskWyłącz(0);
            Console.WriteLine(pilot);
            pilot.WciśniętoPrzyciskWycofaj();

            pilot.WciśniętoPrzyciskWłącz(1);
            Console.WriteLine(pilot);
            pilot.WciśniętoPrzyciskWycofaj();

            Console.WriteLine("///////////");

            pilot.WciśniętoPrzyciskWłącz(2);
            pilot.WciśniętoPrzyciskWyłącz(2);
            Console.WriteLine(pilot);
            pilot.WciśniętoPrzyciskWycofaj();
            pilot.WciśniętoPrzyciskWyłącz(2);
            pilot.WciśniętoPrzyciskWłącz(2);
            Console.WriteLine(pilot);
            pilot.WciśniętoPrzyciskWycofaj();

            ////////////////////////////////////////////////////////////////////////
            
            //SuperPilot pilot = new SuperPilot();

            //Światło jadalniaŚwiatło = new Światło("Jadalnia");

            //Światło kuchniaŚwiatło = new Światło("Kuchnia");

            //WentylatorSufitowy wentylatorSufitowy = new WentylatorSufitowy("Jadalnia");

            //DrzwiGarażowe drzwiGarażowe = new DrzwiGarażowe();

            //WieżaStereo wieżaStereo = new WieżaStereo("Jadalnia");


            //WłączŚwiatłoCommand jadalniaWłączŚwiatło = new WłączŚwiatłoCommand(jadalniaŚwiatło);
            //WyłączŚwiatłoCommand jadalniaWyłączŚwiatło = new WyłączŚwiatłoCommand(jadalniaŚwiatło);
            
            //WłączŚwiatłoCommand kuchniaWłączŚwiatło = new WłączŚwiatłoCommand(kuchniaŚwiatło);
            //WyłączŚwiatłoCommand kuchniaWyłączŚwiatło = new WyłączŚwiatłoCommand(kuchniaŚwiatło);

            //WłączWentylatorSufitowySzybkoCommand włączWentylatorSufitowySzybko = new WłączWentylatorSufitowySzybkoCommand(wentylatorSufitowy);
            //WyłączWentylatorSufitowyCommand wyłączWentylatorSufitowy = new WyłączWentylatorSufitowyCommand(wentylatorSufitowy);

            //OtwórzDrzwiGarażoweCommand otwórzDrzwiGarażowe = new OtwórzDrzwiGarażoweCommand(drzwiGarażowe);
            //ZamknijDrzwiGarażoweCommand zamknijDrzwiGarażowe = new ZamknijDrzwiGarażoweCommand(drzwiGarażowe);

            //WieżaStereoWłączCDCommand wieżaStereoWłączCD = new WieżaStereoWłączCDCommand(wieżaStereo);
            //WieżaStereoWyłączCommand wieżaStereoWyłącz = new WieżaStereoWyłączCommand(wieżaStereo);


            //pilot.UstawPolecenie(0, jadalniaWłączŚwiatło, jadalniaWyłączŚwiatło);
            //pilot.UstawPolecenie(1, kuchniaWłączŚwiatło, kuchniaWyłączŚwiatło);
            //pilot.UstawPolecenie(2, włączWentylatorSufitowySzybko, wyłączWentylatorSufitowy);
            //pilot.UstawPolecenie(3, wieżaStereoWłączCD, wieżaStereoWyłącz);
            //pilot.UstawPolecenie(4, otwórzDrzwiGarażowe, zamknijDrzwiGarażowe);

            //Console.WriteLine(pilot);

            //pilot.WciśniętoPrzyciskWłącz(0);
            //pilot.WciśniętoPrzyciskWyłącz(0);
            //pilot.WciśniętoPrzyciskWłącz(1);
            //pilot.WciśniętoPrzyciskWyłącz(1);
            //pilot.WciśniętoPrzyciskWłącz(2);
            //pilot.WciśniętoPrzyciskWyłącz(2);
            //pilot.WciśniętoPrzyciskWłącz(3);
            //pilot.WciśniętoPrzyciskWyłącz(3);
            //pilot.WciśniętoPrzyciskWłącz(4);
            //pilot.WciśniętoPrzyciskWyłącz(4);

            ////////////////////////////////////////////////////////////////////////

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
