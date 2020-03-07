using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{ 
    public class StarCafeSpecial : Napój
    {
        public StarCafeSpecial()
        {
            opis = "Kawa Star Cafe Special";
        }

        public override double Koszt()
        {
            return 0.89;
        }
    }
}
