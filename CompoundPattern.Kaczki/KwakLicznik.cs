using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class KwakLicznik : IKwacząca
    {
        private readonly IKwacząca _kaczka;
        private static int liczbaKwaknięć;

        public KwakLicznik(IKwacząca kaczka)
        {
            _kaczka = kaczka;
        }

        public void Kwacz()
        {
            _kaczka.Kwacz();
            liczbaKwaknięć++;
        }

        public static int PobierzLiczbaKwaknięć() => liczbaKwaknięć;
        
        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            _kaczka.ZarejestrujObserwatora(obserwator);
        }

        public void PowiadomObserwatorów()
        {
            _kaczka.PowiadomObserwatorów();
        }
    }
}
