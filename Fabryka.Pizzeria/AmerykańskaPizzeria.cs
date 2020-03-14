using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
{
    public class AmerykańskaPizzeria : Pizzeria
    {
        protected override Pizza UtwórzPizza(string typ)
        {
            if (typ.Equals("serowa"))
            {
                return new AmerykańskaSerowaPizza();
            }
            //else if (item.Equals("wegetariańska"))
            //{
            //    return new AmerykańskaWegetariańskaPizza();
            //}
            //else if (item.Equals("owoce morza"))
            //{
            //    return new AmerykańskaOwoceMorzaPizza();
            //}
            //else if (item.Equals("pepperoni"))
            //{
            //    return new AmerykańskaPepperoniPizza();
            //}
            else return null;
        }
    }
}
