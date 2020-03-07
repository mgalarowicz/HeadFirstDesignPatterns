using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia.Kaczki
{
    public class ModelKaczki : Kaczka
    {
        public ModelKaczki()
        {
            latanieInterfejs = new NieLatam();
            kwakanieInterfejs = new KwacZ();
        }

        public override void Wyświetl()
        { 
            Console.WriteLine("Jestem modelem kaczki!");
        }
    }
}
