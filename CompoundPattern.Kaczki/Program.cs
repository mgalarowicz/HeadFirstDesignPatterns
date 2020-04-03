using System;

namespace CompoundPattern.Kaczki
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program symulatorKaczek = new Program();
            symulatorKaczek.Uruchom();
        }

        private void Uruchom()
        {
            IKwacząca dzikaKaczka = new KwakLicznik(new DzikaKaczka());
            IKwacząca płaskonosKaczka = new KwakLicznik(new PłaskonosKaczka());
            IKwacząca wabikKaczka = new KwakLicznik(new WabikKaczka());
            IKwacząca gumowaKaczka = new KwakLicznik(new GumowaKaczka());
            IKwacząca gęśKaczka = new GęśAdapter(new Gęś());

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
