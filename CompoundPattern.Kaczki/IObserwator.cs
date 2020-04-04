using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public interface IObserwator
    {
        void Aktualizuj(IKwakObserwowany kaczka);
    }
}
