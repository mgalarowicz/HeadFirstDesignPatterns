using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public interface IPodmiot
    {
        void ZarejestrujObserwatora(IObserwator o);
        void UsunObserwatora(IObserwator o);
        void PowiadomObserwatorow();

    }
}
