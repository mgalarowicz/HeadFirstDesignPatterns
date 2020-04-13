using System;
using FabrykaAbstrakcyjna.Pizzeria.Fabryki;


namespace FabrykaAbstrakcyjna.Pizzeria.Produkty
{
    public class SerowaPizza : Pizza
    {
        IFabrykaSkładnikówPizzy fabrykaSkladnikow;

        public SerowaPizza(IFabrykaSkładnikówPizzy fabrykaSkladnikow)
        {
            this.fabrykaSkladnikow = fabrykaSkladnikow;
        }
        public override void Przygotowanie()
        {
            Console.WriteLine($"Przygotowanie: {nazwa}");
            ciasto = fabrykaSkladnikow.UtwórzCiasto();
            sos = fabrykaSkladnikow.UtwórzSos();
            ser = fabrykaSkladnikow.UtwórzSer();
            Console.WriteLine($"    {ciasto.Opis}");
            Console.WriteLine($"    {sos.Opis}");
            Console.WriteLine($"    {ser.Opis}");
        }
    }
}
