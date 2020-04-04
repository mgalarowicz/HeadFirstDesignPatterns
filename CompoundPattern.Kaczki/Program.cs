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
            
            IKwacząca płaskonosKaczka = kaczkaFabryka.UtwórzPłaskonosKaczka();
            IKwacząca wabikKaczka = kaczkaFabryka.UtwórzWabikKaczka();
            IKwacząca gumowaKaczka = kaczkaFabryka.UtwórzGumowaKaczka();
            IKwacząca gęśKaczka = gęśFabryka.UtwórzGęś();

            Console.WriteLine("\nSymulator Kaczek: z wzorcem Obserwator");

            Stado stadoKaczek = new Stado();

            stadoKaczek.Dodaj(płaskonosKaczka);
            stadoKaczek.Dodaj(wabikKaczka);
            stadoKaczek.Dodaj(gumowaKaczka);
            stadoKaczek.Dodaj(gęśKaczka);

            Stado stadoDzikichKaczek = new Stado();

            IKwacząca dzikaKaczkaJeden = kaczkaFabryka.UtwórzDzikaKaczka();
            IKwacząca dzikaKaczkaDwa = kaczkaFabryka.UtwórzDzikaKaczka();
            IKwacząca dzikaKaczkaTrzy = kaczkaFabryka.UtwórzDzikaKaczka();
            IKwacząca dzikaKaczkaCztery = kaczkaFabryka.UtwórzDzikaKaczka();

            stadoDzikichKaczek.Dodaj(dzikaKaczkaJeden);
            stadoDzikichKaczek.Dodaj(dzikaKaczkaDwa);
            stadoDzikichKaczek.Dodaj(dzikaKaczkaTrzy);
            stadoDzikichKaczek.Dodaj(dzikaKaczkaCztery);

            stadoKaczek.Dodaj(stadoDzikichKaczek);

            Kwakolog kwakolog = new Kwakolog();
            stadoKaczek.ZarejestrujObserwatora(kwakolog);

            Console.WriteLine("\nSymulator Kaczek: Symulacja całego stada");
            Uruchom(stadoKaczek);

            Console.WriteLine($"Kaczki kwaknęły {KwakLicznik.PobierzLiczbaKwaknięć()} razy");

        }

        private void Uruchom(IKwacząca kaczka)
        {
            kaczka.Kwacz();
        }
    }
}
