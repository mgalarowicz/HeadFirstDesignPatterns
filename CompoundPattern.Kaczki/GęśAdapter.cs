using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class GęśAdapter : IKwacząca
    {
        private readonly Gęś _gęś;
        private readonly Obserwowany _obserwowany;

        public GęśAdapter(Gęś gęś)
        {
            _gęś = gęś;
            _obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            _gęś.Gęgaj();
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
