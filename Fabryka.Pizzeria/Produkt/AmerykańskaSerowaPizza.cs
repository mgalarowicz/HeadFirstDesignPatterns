using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
{
    public class AmerykańskaSerowaPizza : Pizza
    {
        public AmerykańskaSerowaPizza()
        {
            nazwa = "Amerykańska Pizza Serowa";
            ciasto = "Extra grube, chrupkie ciasto";
            sos = "Sos z pomidorów śliwkowych";

            dodatki.Add("Grubo tarty ser Mozzarella");
        }

        public override void Krojenie()
        {
            Console.WriteLine("Krojenie pizzy na kwadratowe kawałki");
        }
    }
}
