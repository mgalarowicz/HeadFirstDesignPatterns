using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class Projektor
    {
        private readonly string _opis;
        private readonly OdtwarzaczDVD _odtwarzaczDvd;

        public Projektor(string opis, OdtwarzaczDVD odtwarzaczDvd)
        {
            _opis = opis;
            _odtwarzaczDvd = odtwarzaczDvd;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_opis} włączony");
        }

        public void TrybSzerokoekranowy()
        {
            Console.WriteLine($"{_opis} w trybie szerokoekranowym");
        }

        public void TrybTV()
        {
            Console.WriteLine($"{_opis} w trybie TV");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"{_opis} wyłączony");
        }

        public override string ToString()
        {
            return _opis;
        }
    }
}
