using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class Czekolada : SkładnikDekorator
    {
        Napój napój;

        public Czekolada(Napój napój)
        {
            this.napój = napój;
        }

        public override string PobierzOpis()
        {
            return napój.PobierzOpis() + ", Czekolada";
        }

        public override double Koszt()
        {
            return napój.Koszt() + 0.20;
        }
    }
}
