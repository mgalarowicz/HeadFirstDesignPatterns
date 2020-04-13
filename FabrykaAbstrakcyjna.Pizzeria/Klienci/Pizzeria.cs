using FabrykaAbstrakcyjna.Pizzeria.Produkty;

namespace FabrykaAbstrakcyjna.Pizzeria.Klienci
{
    public abstract class Pizzeria
    {
        public Pizza ZamówPizza(string typ)
        { 
            Pizza pizza = UtwórzPizza(typ);

            pizza.Przygotowanie();
            pizza.Pieczenie();
            pizza.Krojenie();
            pizza.Pakowanie();

            return pizza;
        }

        protected abstract Pizza UtwórzPizza(string typ);
    }
}
