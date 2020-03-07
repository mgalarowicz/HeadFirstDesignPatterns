using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia.Kaczki
{
    public class DzikaKaczka : Kaczka
    {
        public DzikaKaczka()
        {
            kwakanieInterfejs = new KwacZ();
            latanieInterfejs = new LatamBoMamSkrzydła();
        }

        public override void Wyświetl()
        {
            Console.WriteLine("Jestem prawdziwą dziką kaczką!");
        }
    }
}
