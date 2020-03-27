using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class PozycjaMenu
    {
        private readonly string _nazwa;
        private readonly string _opis;
        private readonly bool _wegetariańska;
        private readonly double _cena;

        public PozycjaMenu(string nazwa, string opis, bool wegetariańska, double cena)
        {
            _nazwa = nazwa;
            _opis = opis;
            _wegetariańska = wegetariańska;
            _cena = cena;
        }

        public string PobierzNazwa() => _nazwa;
        
        public string PobierzOpis() => _opis;

        public double PobierzCena() => _cena;

        public bool JestWegetariańska() => _wegetariańska;
    }
}
