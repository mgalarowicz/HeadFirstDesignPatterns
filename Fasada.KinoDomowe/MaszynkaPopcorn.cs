using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class MaszynkaPopcorn
    {
        private readonly string _opis;

        public MaszynkaPopcorn(string opis)
        {
            _opis = opis;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_opis} włączony");
        }

        public void PrzygotujPopcorn()
        {
            Console.WriteLine($"{_opis} przygotowuje popcorn!");
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
