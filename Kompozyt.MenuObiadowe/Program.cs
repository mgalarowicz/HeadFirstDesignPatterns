using System;

namespace Kompozyt.MenuObiadowe
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSkładnik pancakeHouseMenu = new Menu("MENU PANCAKE HOUSE", "Śniadania");
            MenuSkładnik dinerMenu = new Menu("MENU RESTAURACJI DINER", "Lunch");
            MenuSkładnik uJackaMenu = new Menu("MENU U JACKA", "Śniadania");
            MenuSkładnik deseryMenu = new Menu("MENU DESEROW", "Śniadania");

            MenuSkładnik wszystkieMenu = new Menu("WSZYSTKIE MENU", "Połączone Menu");

            wszystkieMenu.Dodaj(pancakeHouseMenu);
            wszystkieMenu.Dodaj(dinerMenu);
            wszystkieMenu.Dodaj(uJackaMenu);
            
            //kod dodawania elementów menu

            dinerMenu.Dodaj(new PozycjaMenu(
                "Spaghetti",
                "Makaron spaghetti z sosem marinara i kromka chleba na zakwasie",
                true,
                3.89));

            dinerMenu.Dodaj(deseryMenu);

            deseryMenu.Dodaj(new PozycjaMenu(
                "Szarlotka",
                "Szarlotka z lodami waniliowymi",
                true,
                1.59));

            //dalsze pozycje menu

            Kelnerka kelnerka = new Kelnerka(wszystkieMenu);

            kelnerka.DrukujMenu();
        }
    }
}
