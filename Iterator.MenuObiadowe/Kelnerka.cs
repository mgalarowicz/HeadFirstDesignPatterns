using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class Kelnerka
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;

        public Kelnerka(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void DrukujMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.UtwórzIterator();
            IIterator dinerIterator = _dinerMenu.UtwórzIterator();

            Console.WriteLine("MENU\n-----\nŚNIADANIA");
            DrukujMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            DrukujMenu(dinerIterator);

        }

        public void DrukujMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                PozycjaMenu pozycjaMenu = (PozycjaMenu)iterator.Next();
                Console.WriteLine($"{pozycjaMenu.PobierzNazwa()}, {pozycjaMenu.PobierzCena()} -- {pozycjaMenu.PobierzOpis()}");
            }
        }
    }
}
