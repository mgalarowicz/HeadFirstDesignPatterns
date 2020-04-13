using System;
using FabrykaAbstrakcyjna.Pizzeria.Fabryki;

namespace FabrykaAbstrakcyjna.Pizzeria.Produkty
{
    public class OwoceMorzaPizza : Pizza
    {
        IFabrykaSkładnikówPizzy fabrykaSkladnikow;

        public OwoceMorzaPizza(IFabrykaSkładnikówPizzy fabrykaSkladnikow)
        {
            this.fabrykaSkladnikow = fabrykaSkladnikow;
        }
        public override void Przygotowanie()
        {
            Console.WriteLine($"Przygotowanie: {nazwa}");
            ciasto = fabrykaSkladnikow.UtwórzCiasto();
            sos = fabrykaSkladnikow.UtwórzSos();
            ser = fabrykaSkladnikow.UtwórzSer();
            małże = fabrykaSkladnikow.UtwórzMałże();
            Console.WriteLine($"    {ciasto.Opis}");
            Console.WriteLine($"    {sos.Opis}");
            Console.WriteLine($"    {ser.Opis}");
            Console.WriteLine($"    {małże.Opis}");
        }
    }
}
