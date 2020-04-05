using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class OdtwarzaczCD
    {
        private string _tytuł;
        int _aktualnyKawałek;
        private readonly string _opis;
        private readonly Wzmacniacz _wzmacniacz;

        public OdtwarzaczCD(string opis, Wzmacniacz wzmacniacz)
        {
            _opis = opis;
            _wzmacniacz = wzmacniacz;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_opis} włączony");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"{_opis} wyłączony");
        }

        public void WysuńDysk()
        {
            _tytuł = null;
            Console.WriteLine($"{_opis} wysunięty");
        }

        public void Odtwarzaj(string tytuł)
        {
            _tytuł = tytuł;
            _aktualnyKawałek = 0;
            Console.WriteLine($"{_opis} gra: {tytuł}");
        }

        public void Odtwarzaj(int piosenka)
        {
            if (_tytuł == null)
            {
            Console.WriteLine($"{_opis} nie może zagrać {_aktualnyKawałek}, cd nie zostało włożone");
            }
            else
            {
                _aktualnyKawałek = piosenka;
                Console.WriteLine($"{_opis} gra: {_aktualnyKawałek}");
            }
        }

        public void Zatrzymaj()
        {
            _aktualnyKawałek = 0;
            Console.WriteLine($"{_opis} zatrzymany");
        }

        public void Pauza()
        {
            Console.WriteLine($"{_opis} zapauzowany: {_tytuł}");
        }

        public override string ToString()
        {
            return _opis;
        }

    }
}
