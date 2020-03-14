//using System;
//using System.Collections.Generic;
//using System.Text;
//using Fabryka.Pizzeria;
//using Fabryka.Pizzeria.Składniki;

//namespace Fabryka.Pizzeria.WariantZeSkładnikami
//{
//    public class WłoskaPizzeria_ : Pizzeria
//    {
//        protected override Pizza UtwórzPizza(string typ)
//        {
//            Pizza_ pizza;
//            IFabrykaSkładnikówPizzy fabrykaSkładników = new WłoskaFabrykaSkładnikówPizzy();

//            if (typ.Equals("serowa"))
//            {
//                pizza = new SerowaPizza(fabrykaSkładników);
//                pizza.UstawNazwa("Włoska Pizza Serowa");
//            }
//            else if (typ.Equals("wegetariańska"))
//            {
//                pizza = new WegetariańskaPizza(fabrykaSkładników);
//                pizza.UstawNazwa("Włoska Pizza Wegetariańska");
//            }
//            else if (typ.Equals("owoce morza"))
//            {
//                pizza = new OwoceMorzaPizza(fabrykaSkładników);
//                pizza.UstawNazwa("Włoska Pizza Owoce Morza");
//            }
//            else if (typ.Equals("pepperoni"))
//            {
//                pizza = new PepperoniPizza(fabrykaSkładników);
//                pizza.UstawNazwa("Włoska Pizza Pepperoni");
//            }
//            return pizza;
//        }
//    }
//}
