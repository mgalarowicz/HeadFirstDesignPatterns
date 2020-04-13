using System;
using FabrykaAbstrakcyjna.Pizzeria.Klienci;
using FabrykaAbstrakcyjna.Pizzeria.Produkty;

namespace FabrykaAbstrakcyjna.Pizzeria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Klienci.Pizzeria włoskaPizzeria = new WłoskaPizzeria();
            włoskaPizzeria.ZamówPizza("serowa");

        }
    }
}
