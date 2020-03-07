using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public override Wielkość PobierzWielkość()
        {
            return napój.PobierzWielkość();
        }


        public override double Koszt()
        {
            double kosztDodatku;
            
            switch (PobierzWielkość())
            {
                case Wielkość.Mała:
                    kosztDodatku = 0.10;
                    break;
                case Wielkość.Średnia:
                    kosztDodatku = 0.15;
                    break;
                case Wielkość.Duża:
                    kosztDodatku = 0.20;
                    break;
                default:
                    kosztDodatku = 0.15;
                    break;
            }

            return napój.Koszt() + kosztDodatku;
        }
    }
}
