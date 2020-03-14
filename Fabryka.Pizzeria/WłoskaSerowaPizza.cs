using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
{ 
    public class WłoskaSerowaPizza : Pizza
    {
        public WłoskaSerowaPizza()
        {
            nazwa = "Włoska pizza serowa z sosem Marinara";
            ciasto = "Cienkie kruche ciasto";
            sos = "Sos Marinara";

            dodatki.Add("Tarty ser Reggiano");
        }
    }
}
