using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public class Menu : MenuSkładnik
    {
        private readonly string _nazwa;
        private readonly string _opis;
        private ArrayList _menuSkładniki = new ArrayList();

        public Menu(string nazwa, string opis)
        {
            _nazwa = nazwa;
            _opis = opis;
        }

        public override void Dodaj(MenuSkładnik menuSkładnik)
        {
            _menuSkładniki.Add(menuSkładnik);
        }

        public override void Usuń(MenuSkładnik menuSkładnik)
        {
            _menuSkładniki.Remove(menuSkładnik);
        }

        public override MenuSkładnik PobierzPotomek(int i) => (MenuSkładnik)_menuSkładniki[i];

        public override string PobierzNazwa() => _nazwa;
        public override string PobierzOpis() => _opis;

        public override void Drukuj()
        {
            Console.WriteLine($"\n {PobierzNazwa()}");
            Console.WriteLine($", {PobierzOpis()}");
            Console.WriteLine($"--------------------");

            //JAVA IMPL - wykorzystanie wzorca iterator

            //IIterator iterator = _menuSkładniki.Iterator();
            //while (iterator.HasNext())
            //{
            //    var menuSkładnik = (MenuSkładnik)iterator.Next();
            //    menuSkładnik.Drukuj();
            //}

            //IEnumerator iterator = _menuSkładniki.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    var menuSkładnik = (MenuSkładnik)iterator.Current;
            //    menuSkładnik.Drukuj();
            //}
        }
    }
}
