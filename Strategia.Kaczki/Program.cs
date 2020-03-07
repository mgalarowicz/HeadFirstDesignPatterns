using System;

namespace Strategia.Kaczki
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kaczka dzika = new DzikaKaczka();
            dzika.WykonajKwacz();
            dzika.WykonajLeć();

            Kaczka model = new ModelKaczki();
            model.WykonajLeć();
            model.UstawLatanie(new LotZNapędemRakietowym());
            model.WykonajLeć();

            Wabik wabik = new Wabik();
            wabik.UstawKwakanie(new KwacZ());
            wabik.WykonajKwacz();
        }
    }
}
