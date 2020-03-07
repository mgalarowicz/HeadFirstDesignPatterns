using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class Espresso : Napój
    {
        public Espresso()
        {
            opis = $"Kawa Espresso";
        }

        public override double Koszt()
        {
            return 1.99;
        }
    }
}
