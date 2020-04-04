using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public interface IKwakObserwowany
    {
        void ZarejestrujObserwatora(IObserwator obserwator);
        void PowiadomObserwatorów();
    }
}
