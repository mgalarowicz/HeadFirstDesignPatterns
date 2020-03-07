using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class MocnoPalona : Napój
    {
        public MocnoPalona()
        {
            opis = $"Kawa Mocno Palona";
        }

        public override double Koszt()
        {
            return 0.99;
        }
    }
}
