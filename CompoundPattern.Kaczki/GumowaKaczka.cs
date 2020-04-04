using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class GumowaKaczka : IKwacząca
    {
        private readonly Obserwowany _obserwowany;

        public GumowaKaczka()
        {
            _obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            Console.WriteLine("Piszczę!");
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
