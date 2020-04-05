using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class OświetlenieKinowe
    {
        private readonly string _opis;

        public OświetlenieKinowe(string opis)
        {
            _opis = opis;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_opis} włączony");
        }

        public void Ściemniaj(int poziom)
        {
            Console.WriteLine($"{_opis} ściemniany do poziomu {poziom}");
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
