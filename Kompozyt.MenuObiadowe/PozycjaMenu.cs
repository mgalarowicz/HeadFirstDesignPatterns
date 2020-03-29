using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public class PozycjaMenu : MenuSkładnik
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

        public override string PobierzNazwa() => _nazwa;
        public override string PobierzOpis() => _opis;
        public override double PobierzCena() => _cena;
        public override bool JestWegetariańska() => _wegetariańska;

        public override void Drukuj()
        {
            Console.WriteLine($"   {PobierzNazwa()}");
            if (JestWegetariańska())
                Console.Write("(w)");
            Console.WriteLine($", {PobierzCena()}  ---- {PobierzOpis()}");
        }

        public override IIterator UtwórzIterator() => new IteratorPusty();
    }
}
