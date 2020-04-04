using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class DzikaKaczka : IKwacząca
    {
        Obserwowany obserwowany;

        public DzikaKaczka()
        {
            obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            Console.WriteLine("Kwa! Kwa!");
            PowiadomObserwatorów();
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            obserwowany.ZarejestrujObserwatora(obserwator);
        }

        public void PowiadomObserwatorów()
        {
            obserwowany.PowiadomObserwatorów();
        }
    }
}
