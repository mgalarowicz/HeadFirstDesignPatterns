using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class DinerMenu
    {
        private const int MAKS_LICZBA_ELEMENTOW = 6;
        int liczbaElementów = 0;
        PozycjaMenu[] pozycjeMenu;

        public DinerMenu()
        {
            pozycjeMenu = new PozycjaMenu[MAKS_LICZBA_ELEMENTOW];

            DodajElement("Wegetariańska Kanapka BSP", "(Wegetariański) Boczek z sałatą i pomidorem, chleb pszenny pełnoziarnisty", true, 2.99);
            DodajElement("Kanapka BSP", "Boczek z sałatą i pomidorem, chleb pszenny pełnoziarnisty", false, 2.99);
            DodajElement("Zupa dnia", "Zupa dnia i sałatka z pomidora", false, 3.29);
            DodajElement("Hot-dog", "Hot-dog z kiszoną kapustą, rzodkiewką, cebulą i dodatkiem sera", false, 3.05);
            DodajElement("Kanapka X", "X", false, 2.99);
            DodajElement("Kanapka Y", "Y", true, 3.99);
        }

        public void DodajElement(string nazwa, string opis, bool wegetariańska, double cena)
        {
            PozycjaMenu pozycjaMenu = new PozycjaMenu(nazwa, opis, wegetariańska, cena);
            
            if (liczbaElementów >= MAKS_LICZBA_ELEMENTOW)
            {
                Console.WriteLine("Niestety menu jest pełne! Nie można dodać nowej pozycji");
            }
            else
            {
                pozycjeMenu[liczbaElementów] = pozycjaMenu;
                liczbaElementów += 1;
            }
        }
        
        public IIterator UtwórzIterator() => new DinerMenuIterator(pozycjeMenu);

    }
}
