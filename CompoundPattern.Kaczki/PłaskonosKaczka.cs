using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class PłaskonosKaczka : IKwacząca
    {
        private readonly Obserwowany _obserwowany;

        public PłaskonosKaczka()
        {
            _obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            Console.WriteLine("Kwa! Kwa!");
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
