using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.NapojeKofeinowe
{
    public abstract class NapójZKofeiną
    {
        public void RecepturaParzenia()
        {
            GotowanieWody();
            Zaparzanie();
            NalewanieDoFiliżanki();

            if (CzyKlientChceDodatki())
                DomieszanieDodatków();
        }

        public abstract void Zaparzanie();

        public abstract void DomieszanieDodatków();

        private void GotowanieWody()
        {
            Console.WriteLine("Gotowanie wody");
        }

        private void NalewanieDoFiliżanki()
        {
            Console.WriteLine("Nalewanie do filiżanki");
        }

        public virtual bool CzyKlientChceDodatki() => true;
    }
}
