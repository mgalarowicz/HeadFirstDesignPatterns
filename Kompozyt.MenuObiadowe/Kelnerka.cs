using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public class Kelnerka
    {
        private readonly MenuSkładnik _wszystkieMenu;

        public Kelnerka(MenuSkładnik wszystkieMenu)
        {
            _wszystkieMenu = wszystkieMenu;
        }

        public void DrukujMenu() => _wszystkieMenu.Drukuj();

        public void DrukujMenuWegetariańskie()
        {
            IIterator iterator = _wszystkieMenu.UtwórzIterator();

            Console.WriteLine("\nMENU WEGETARIAŃSKIE\n-----");

            while (iterator.HasNext())
            {
                MenuSkładnik menuSkładnik = (MenuSkładnik)iterator.Next();

                try
                {
                    if (menuSkładnik.JestWegetariańska())
                        menuSkładnik.Drukuj();
                }
                catch (InvalidOperationException) { }
            }
        }

    }
}
