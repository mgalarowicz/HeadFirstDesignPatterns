using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    //KUCHARZ
    public class Światło
    {
        private readonly string _pomieszczenie = string.Empty;
        
        public Światło() { }

        public Światło(string pomieszczenie)
        {
            _pomieszczenie = pomieszczenie;
        }

        public void Włącz()
        {
            Console.WriteLine($"Światło zostało włączone w {_pomieszczenie}");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"Światło zostało wyłączone w {_pomieszczenie}");
        }
    }
}
