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

    }
}
