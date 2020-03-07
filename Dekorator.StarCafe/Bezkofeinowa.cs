using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public class Bezkofeinowa : Napój
    {
        public Bezkofeinowa()
        {
            opis = "Kawa Bezkofeinowa";
        }

        public override double Koszt()
        {
            return 1.05;
        }
    }
}
