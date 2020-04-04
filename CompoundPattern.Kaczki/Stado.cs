using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class Stado : IKwacząca
    {
        private readonly ArrayList _ptaki = new ArrayList();

        public void Dodaj(IKwacząca ptak)
        {
            _ptaki.Add(ptak);    
        }

        public void Kwacz()
        {
            IIterator iterator = new PtakiIterator(_ptaki);
            
            while (iterator.HasNext())
            {
                IKwacząca ptak = (IKwacząca)iterator.Next();
                ptak.Kwacz();
            }
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            IIterator iterator = new PtakiIterator(_ptaki);

            while (iterator.HasNext())
            {
                IKwacząca ptak = (IKwacząca)iterator.Next();
                ptak.ZarejestrujObserwatora(obserwator);
            }
        }

        public void PowiadomObserwatorów() { }

    }
}
