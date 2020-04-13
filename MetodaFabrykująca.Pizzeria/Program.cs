using System;

namespace Fabryka.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria włoska = new WłoskaPizzeria();
            Pizzeria amerykańska = new AmerykańskaPizzeria();

            Pizza pizza = włoska.ZamówPizza("serowa");
            Console.WriteLine($"Eryk zamówił: {pizza.PobierzNazwa()} \n");

            pizza = amerykańska.ZamówPizza("serowa");
            Console.WriteLine($"Eryk zamówił: {pizza.PobierzNazwa()} \n");
        }
    }
}
