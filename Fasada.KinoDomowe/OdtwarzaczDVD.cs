using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class OdtwarzaczDVD
    {
        private readonly string _opis;
        private readonly Wzmacniacz _wzmacniacz;
        private int _aktualnyKawałek;
        private string _film;

        public OdtwarzaczDVD(string opis, Wzmacniacz wzmacniacz)
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
            _film = null;
            Console.WriteLine($"{_opis} wysunięty");
        }

        public void Odtwarzaj(string film)
        {
            _film = film;
            _aktualnyKawałek = 0;
            Console.WriteLine($"{_opis} gra: {film}");
        }

        public void Odtwarzaj(int tytuł)
        {
            if (_film == null)
            {
                Console.WriteLine($"{_opis} nie może zagrać {_aktualnyKawałek}, cd nie zostało włożone");
            }
            else
            {
                _aktualnyKawałek = tytuł;
                Console.WriteLine($"{_opis} gra: {_aktualnyKawałek} z {_film}");
            }
        }

        public void Zatrzymaj()
        {
            _aktualnyKawałek = 0;
            Console.WriteLine($"{_opis} zatrzymany {_film}");
        }

        public void Pauza()
        {
            Console.WriteLine($"{_opis} zapauzowany: {_film}");
        }

        public void UstawDwukanałoweAudio()
        {
            Console.WriteLine($"{_opis} ustawony na dwukanałowe audio");
        }

        public void UstawPrzestrzennyEfektAudio()
        {
            Console.WriteLine($"{_opis} ustawiony na przestrzenny efekt audio");
        }

        public override string ToString()
        {
            return _opis;
        }
    }
}
