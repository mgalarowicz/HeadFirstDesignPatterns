using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.IndykiKaczki
{
    public class DzikaKaczka : IKaczka
    {
        public void Kwacz()
        {
            Console.WriteLine("Kwa! Kwa!");
        }

        public void Lataj()
        {
            Console.WriteLine("O rany! Latam!");
        }
    }
}
