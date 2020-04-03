using System;

namespace CompoundPattern.Kaczki
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program symulatorKaczek = new Program();
            AbstrakcyjnaFabrykaKaczek kaczkaFabryka = new FabrykaKaczekZLicznikiem();
            AbstrakcyjnaFabrykaGęsi gęśFabryka = new FabrykaGęsiJakoKaczki();

            symulatorKaczek.Uruchom(kaczkaFabryka, gęśFabryka);
        }

        private void Uruchom(AbstrakcyjnaFabrykaKaczek kaczkaFabryka, AbstrakcyjnaFabrykaGęsi gęśFabryka)
        {
            IKwacząca dzikaKaczka = kaczkaFabryka.UtwórzDzikaKaczka();
            IKwacząca płaskonosKaczka = kaczkaFabryka.UtwórzPłaskonosKaczka();
            IKwacząca wabikKaczka = kaczkaFabryka.UtwórzWabikKaczka();
            IKwacząca gumowaKaczka = kaczkaFabryka.UtwórzGumowaKaczka();
            IKwacząca gęśKaczka = gęśFabryka.UtwórzGęś();

            Console.WriteLine("\nSymulator Kaczek: z wzorcem Dekorator");

            Uruchom(dzikaKaczka);
            Uruchom(płaskonosKaczka);
            Uruchom(wabikKaczka);
            Uruchom(gumowaKaczka);
            Uruchom(gęśKaczka);

            Console.WriteLine($"Kaczki kwaknęły {KwakLicznik.PobierzLiczbaKwaknięć()} razy");
        }

        private void Uruchom(IKwacząca kaczka)
        {
            kaczka.Kwacz();
        }
    }
}
