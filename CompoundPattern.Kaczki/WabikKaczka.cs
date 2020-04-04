using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class WabikKaczka : IKwacząca
    {
        private Obserwowany _obserwowany;

        public WabikKaczka()
        {
            _obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            Console.WriteLine("Kwak");
            PowiadomObserwatorów();
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            _obserwowany.ZarejestrujObserwatora(obserwator);
        }

        public void PowiadomObserwatorów()
        {
            _obserwowany.PowiadomObserwatorów();
        }
    }
}
