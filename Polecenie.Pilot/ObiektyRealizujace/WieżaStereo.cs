using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    public class WieżaStereo
    {
        private readonly string _pomieszczenie;

        public WieżaStereo(string pomieszczenie)
        {
            _pomieszczenie = pomieszczenie;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo włączona");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo wyłączona");
        }

        public void UstawCD()
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo w trybie CD");
        }

        public void UstawDVD()
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo w trybie DVD");
        }

        public void UstawRadio()
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo w trybie Radio");
        }

        public void UstawGłośność(int volume)
        {
            Console.WriteLine($"{_pomieszczenie}: Wieża stereo ustawiona na głośność: {volume}");
        }
    }
}
