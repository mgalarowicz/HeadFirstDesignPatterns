using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class Wzmacniacz
    {
        private readonly string _opis;
        private Tuner _tuner;
        private OdtwarzaczDVD _dvd;
        private OdtwarzaczCD _cd;

        public Wzmacniacz(string opis)
        {
            _opis = opis;
        }

        public void Włącz()
        {
            Console.WriteLine($"{_opis} włączony");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"{_opis} wyłączony");
        }

        public void UstawDźwiękStereo()
        {
            Console.WriteLine($"{_opis} moduł stereo włączony");
        }

        public void UstawDźwiękPrzestrzenny()
        {
            Console.WriteLine($"{_opis} dźwięk przestrzenny włączony (5 głośników)");
        }

        public void UstawGłośność(int volume)
        {
            Console.WriteLine($"{_opis} ustawianie głośności na {volume}");
        }

        public void UstawTuner(Tuner tuner)
        {
            Console.WriteLine($"{_opis} ustawianie tunera do {_dvd}");
            _tuner = tuner;
        }

        public void UstawDVD(OdtwarzaczDVD dvd)
        {
            Console.WriteLine($"{_opis} ustawianie odtwarzacza dvd: {dvd}");
            _dvd = dvd;
        }

        public void UstawCD(OdtwarzaczCD cd)
        {
            Console.WriteLine($"{_opis} ustawianie odtwarzacza dvd: {cd}");
            _cd = cd;
        }

        public override string ToString()
        {
            return _opis;
        }
    }
}
