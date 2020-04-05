using System;

namespace Fasada.KinoDomowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Wzmacniacz _wzmacniacz = new Wzmacniacz("Top-O-Line wzmacniacz");
            Tuner _tuner = new Tuner("Top-O-Line AM/FM tuner", _wzmacniacz);
            OdtwarzaczCD _cd = new OdtwarzaczCD("Top-O-Line odtwarzacz CD", _wzmacniacz);
            OdtwarzaczDVD _dvd = new OdtwarzaczDVD("Top-O-Line odtwarzacz DVD", _wzmacniacz);
            Projektor _projektor = new Projektor("Top-O-Line projektor", _dvd);
            Ekran _ekran = new Ekran("Wielki ekran");
            OświetlenieKinowe _oświetlenie = new OświetlenieKinowe("Oświetlenie kinowe");
            MaszynkaPopcorn _popcorn = new MaszynkaPopcorn("Maszynka do popcornu");

            FasadaKinaDomowego kinoDomowe = new FasadaKinaDomowego(_wzmacniacz, _tuner, _cd, _dvd, _projektor, _ekran, _oświetlenie, _popcorn);

            kinoDomowe.OdtwarzanieFilmu("Powrót do przyszłosći");
            kinoDomowe.KoniecFilmu();
        }
    }

}
