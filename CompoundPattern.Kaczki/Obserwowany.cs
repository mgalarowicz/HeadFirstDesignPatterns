using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class Obserwowany : IKwakObserwowany
    {
        private readonly IKwakObserwowany _kaczka;
        ArrayList obserwatorzy = new ArrayList();

        public Obserwowany(IKwakObserwowany kaczka)
        {
            _kaczka = kaczka;
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            obserwatorzy.Add(obserwator);
        }

        public void PowiadomObserwatorów()
        {
            IIterator iterator = new ObserwatorzyIterator(obserwatorzy);

            while (iterator.HasNext())
            {
                IObserwator obserwator = (IObserwator)iterator.Next();
                obserwator.Aktualizuj(_kaczka);
            }
        }
    }
}
