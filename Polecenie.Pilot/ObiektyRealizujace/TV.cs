using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    public class TV
    {
        private readonly string _pomieszczenie;

        public TV(string pomieszczenie)
        {
            _pomieszczenie = pomieszczenie;
        }

        public void Włącz()
        {
            Console.WriteLine($"Telewizor włączony w {_pomieszczenie}");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"Telewizor wyłączony w {_pomieszczenie}");
        }
    }
}
