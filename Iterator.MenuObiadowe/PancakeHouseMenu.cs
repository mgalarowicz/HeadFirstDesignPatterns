using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class PancakeHouseMenu : IMenu
    {
        ArrayList _pozycjeMenu;

        public PancakeHouseMenu()
        {
            _pozycjeMenu = new ArrayList();

            DodajElement("Śniadanie naleśnikowe K&B", "Naleśniki z jajecznicą i tostem", true, 2.99);
            DodajElement("Śniadanie naleśnikowe zwykłe", "Naleśniki z jajkiem sadzonym i kiełbasą", false, 2.99);
            DodajElement("Naleśniki z jagodami", "Naleśniki ze świeżymi jagodami", true, 3.49);
            DodajElement("Wafle nadziewane", "Wafle z jagodami lub truskawkami", true, 3.59);
        }

        public void DodajElement(string nazwa, string opis, bool wegetariańska, double cena)
        {
            PozycjaMenu pozycjaMenu = new PozycjaMenu(nazwa, opis, wegetariańska, cena);
            _pozycjeMenu.Add(pozycjaMenu);
        }

        public IIterator UtwórzIterator() => new PancakeHouseMenuIterator(_pozycjeMenu);
    }
}
