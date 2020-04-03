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
            IKwacząca dzikaKaczka = new DzikaKaczka();
            IKwacząca płaskonosKaczka = new PłaskonosKaczka();
            IKwacząca wabikKaczka = new WabikKaczka();
            IKwacząca gumowaKaczka = new GumowaKaczka();
            IKwacząca gęśKaczka = new GęśAdapter(new Gęś());

            Console.WriteLine("\nSymulator Kaczek");

            Uruchom(dzikaKaczka);
            Uruchom(płaskonosKaczka);
            Uruchom(wabikKaczka);
            Uruchom(gumowaKaczka);
            Uruchom(gęśKaczka);
        }

        private void Uruchom(IKwacząca kaczka)
        {
            kaczka.Kwacz();
        }
    }
}
