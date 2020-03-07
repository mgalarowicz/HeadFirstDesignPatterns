using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public interface IObserwator
    {
        void Aktualizacja(float temp, float wilgotnosc, float cisnienie);
    }
}
