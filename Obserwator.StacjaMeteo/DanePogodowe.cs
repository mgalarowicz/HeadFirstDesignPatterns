using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public class DanePogodowe : IPodmiot
    {
        private List<IObserwator> obserwatorzy;
        private float temperatura;
        private float wilgotnosc;
        private float cisnienie;

        public DanePogodowe()
        {
            obserwatorzy = new List<IObserwator>();
        }


        public void ZarejestrujObserwatora(IObserwator o)
        {
            obserwatorzy.Add(o);
        }

        public void UsunObserwatora(IObserwator o)
        {
            if (obserwatorzy.Contains(o))
            {
                obserwatorzy.Remove(o);
            }
        }

        public void PowiadomObserwatorow()
        {
            foreach (var obs in obserwatorzy)
            {
                obs.Aktualizacja(temperatura, wilgotnosc, cisnienie);
            }
        }

        public void OdczytyZmiana()
        {
            PowiadomObserwatorow();
        }

        public void UstawOdczyty(float temperatura, float wilgotnosc, float cisnienie)
        {
            this.temperatura = temperatura;
            this.wilgotnosc = wilgotnosc;
            this.cisnienie = cisnienie;
            OdczytyZmiana();
        }
    }
}
