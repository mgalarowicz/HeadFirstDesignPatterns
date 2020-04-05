using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada.KinoDomowe
{
    public class FasadaKinaDomowego
    {
        private readonly Wzmacniacz _wzmacniacz;
        private readonly Tuner _tuner;
        private readonly OdtwarzaczCD _cd;
        private readonly OdtwarzaczDVD _dvd;
        private readonly Projektor _projektor;
        private readonly Ekran _ekran;
        private readonly OświetlenieKinowe _oświetlenie;
        private readonly MaszynkaPopcorn _popcorn;

        public FasadaKinaDomowego(Wzmacniacz wzmacniacz,
                                    Tuner tuner,
                                    OdtwarzaczCD cd,
                                    OdtwarzaczDVD dvd,
                                    Projektor projektor,
                                    Ekran ekran,
                                    OświetlenieKinowe oświetlenie,
                                    MaszynkaPopcorn popcorn)
        {
            _wzmacniacz = wzmacniacz;
            _tuner = tuner;
            _cd = cd;
            _dvd = dvd;
            _projektor = projektor;
            _ekran = ekran;
            _oświetlenie = oświetlenie;
            _popcorn = popcorn;
        }

        public void OdtwarzanieFilmu(string film)
        {
            Console.WriteLine("---- Przygotuj się na seans filmowy...");
            _popcorn.Włącz();
            _popcorn.PrzygotujPopcorn();
            _oświetlenie.Ściemniaj(10);
            _ekran.WDół();
            _projektor.Włącz();
            _projektor.TrybSzerokoekranowy();
            _wzmacniacz.Włącz();
            _wzmacniacz.UstawDVD(_dvd);
            _wzmacniacz.UstawDźwiękPrzestrzenny();
            _wzmacniacz.UstawGłośność(5);
            _dvd.Włącz();
            _dvd.Odtwarzaj(film);
        }

        public void KoniecFilmu()
        {
            Console.WriteLine("\n ----- Koniec seansu, wyłączam kino domowe...");
            _popcorn.Wyłącz();
            _oświetlenie.Włącz();
            _ekran.WGórę();
            _projektor.Wyłącz();
            _wzmacniacz.Wyłącz();
            _dvd.Zatrzymaj();
            _dvd.WysuńDysk();
            _dvd.Wyłącz();
        }
    }
}
