using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class Ekran
    {
        private readonly string _opis;

        public Ekran(string opis)
        {
            _opis = opis;
        }

        public void WGórę()
        {
            Console.WriteLine($"{_opis} idzie do góry");
        }

        public void WDół()
        {
            Console.WriteLine($"{_opis} idzie w dół");
        }

        public override string ToString()
        {
            return _opis;
        }
    }
}
