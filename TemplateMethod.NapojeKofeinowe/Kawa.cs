using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.NapojeKofeinowe
{
    public class Kawa : NapójZKofeiną
    {
        public override void Zaparzanie()
        {
            Console.WriteLine("Zaparzanie i przesączanie kawy przez filtr");
        }

        public override void DomieszanieDodatków()
        {
            Console.WriteLine("Dodawanie cukru oraz mleka do smaku");
        }
    }
}
