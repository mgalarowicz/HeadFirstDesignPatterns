using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
{
    public class WłoskaPizzeria : Pizzeria
    {
        protected override Pizza UtwórzPizza(string typ)
        {
            if (typ.Equals("serowa"))
            {
                return new WłoskaSerowaPizza();
            }
            //else if (item.Equals("wegetariańska"))
            //{
            //    return new WłoskaWegetariańskaPizza();
            //}
            //else if (item.Equals("owoce morza"))
            //{
            //    return new WłoskaOwoceMorzaPizza();
            //}
            //else if (item.Equals("pepperoni"))
            //{
            //    return new WłoskaPepperoniPizza();
            //}
            else return null;
        }
    }
}
