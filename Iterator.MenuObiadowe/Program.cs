using System;

namespace Iterator.MenuObiadowe
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Kelnerka kelnerka = new Kelnerka(pancakeHouseMenu, dinerMenu);

            kelnerka.DrukujMenu();
        }
    }
}
