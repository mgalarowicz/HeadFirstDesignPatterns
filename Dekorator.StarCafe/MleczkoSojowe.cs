using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class MleczkoSojowe : SkładnikDekorator
    {
        Napój napój;

        public MleczkoSojowe(Napój napój)
        {
            this.napój = napój;
        }

        public override string PobierzOpis()
        {
            return napój.PobierzOpis() + ", Mleczko Sojowe";
        }

        public override double Koszt()
        {
            return napój.Koszt() + 0.15;
        }
    }
}
