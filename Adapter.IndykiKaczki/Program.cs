using System;

namespace Adapter.IndykiKaczki
{
    class Program
    {
        static void Main(string[] args)
        {
            DzikaKaczka dzikaKaczka = new DzikaKaczka();

            DzikiIndyk dzikiIndyk = new DzikiIndyk();

            IKaczka indykAdapter = new IndykAdapter(dzikiIndyk);

            Console.WriteLine("--- Indyk powiada tak...");
            dzikiIndyk.Gulgocz();
            dzikiIndyk.Lataj();

            Console.WriteLine("--- Kaczka powiada tak...");
            testujKaczkę(dzikaKaczka);

            Console.WriteLine("--- A IndykAdapter powiada tak...");
            testujKaczkę(indykAdapter);
        }

        private static void testujKaczkę(IKaczka kaczka)
        {
            kaczka.Kwacz();
            kaczka.Lataj();
        }
    }
}
