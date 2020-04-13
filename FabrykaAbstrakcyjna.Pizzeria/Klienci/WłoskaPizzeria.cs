using FabrykaAbstrakcyjna.Pizzeria.Fabryki;
using FabrykaAbstrakcyjna.Pizzeria.Produkty;

namespace FabrykaAbstrakcyjna.Pizzeria.Klienci
{
    public class WłoskaPizzeria : Pizzeria
    {
        protected override Pizza UtwórzPizza(string typ)
        {
            Pizza pizza = null;
            IFabrykaSkładnikówPizzy fabrykaSkładników = new WłoskaFabrykaSkładnikówPizzy();

            if (typ.Equals("serowa"))
            {
                pizza = new SerowaPizza(fabrykaSkładników);
                pizza.UstawNazwa("Włoska Pizza Serowa");
            }
            else if (typ.Equals("owoce morza"))
            {
                pizza = new OwoceMorzaPizza(fabrykaSkładników);
                pizza.UstawNazwa("Włoska Pizza Owoce Morza");
            }
            //else if (typ.Equals("pepperoni"))
            //{
            //    pizza = new PepperoniPizza(fabrykaSkładników);
            //    pizza.UstawNazwa("Włoska Pizza PlastryPepperoni");
            //}
            return pizza;
        }
    }
}
