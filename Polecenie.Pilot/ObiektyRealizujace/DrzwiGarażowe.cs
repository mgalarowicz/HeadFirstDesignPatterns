using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    public class DrzwiGarażowe
    {
        public void DoGóry()
        {
            Console.WriteLine("Drzwi garażowe są otwarte");
        }

        public void NaDół()
        {
            Console.WriteLine("Drzwi garażowe są zamknięte");
        }

        public void Stop()
        {
            Console.WriteLine("Drzwi się zatrzymały");
        }

        public void WłączŚwiatło()
        {
            Console.WriteLine("Światło włączone w garażu");
        }

        public void WyłączŚwiatło()
        {
            Console.WriteLine("Światło wyłączone w garażu");
        }
    }
}
