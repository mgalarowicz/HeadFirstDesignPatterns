using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class Kwakolog : IObserwator
    {
        public void Aktualizuj(IKwakObserwowany kaczka)
        {
            Console.WriteLine($"Kwakolog: {kaczka} kwaknęła.");
        }
    }
}
