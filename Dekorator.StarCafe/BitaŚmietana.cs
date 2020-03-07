using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class BitaŚmietana : SkładnikDekorator
    {
        private Napój napój;

        public BitaŚmietana(Napój napój)
        {
            this.napój = napój;
        }
        public override string PobierzOpis()
        {
            return napój.PobierzOpis() + ", Bita Śmietana";
        }

        public override Wielkość PobierzWielkość()
        {
            return napój.PobierzWielkość();
        }

        public override double Koszt()
        {
            return napój.Koszt() + 0.1;
        }
    }
}
