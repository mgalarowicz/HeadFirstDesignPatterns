using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class Tuner
    {
        private readonly string _opis;
        private readonly Wzmacniacz _wzmacniacz;
        private double _częstotliwość;

        public Tuner(string opis, Wzmacniacz wzmacniacz)
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

        public void UstawCzęstotliwość(double częstotliwość)
        {
            Console.WriteLine($"{_opis} ustawianie częstotliwości na {częstotliwość}");
            _częstotliwość = częstotliwość;
        }

        public void UstawZakresAM()
        {
            Console.WriteLine($"{_opis} ustawiony na zakres AM");
        }

        public void UstawZakresFM()
        {
            Console.WriteLine($"{_opis} ustawiony na zakres FM");
        }

        public override string ToString()
        {
            return _opis;
        }
    }
}
