using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
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
