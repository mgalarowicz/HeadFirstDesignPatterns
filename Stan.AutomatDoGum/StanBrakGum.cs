using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class StanBrakGum : IStan
    {
        private readonly AutomatSprzedajacy _automatSprzedajacy;

        public StanBrakGum(AutomatSprzedajacy automatSprzedajacy)
        {
            _automatSprzedajacy = automatSprzedajacy;
        }

        public void WłóżMonetę()
        {
            Console.WriteLine("Nie możesz włożyć monety, gdy automat jest pusty");
        }

        public void ZwróćMonetę()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public void PrzekręćGałkę()
        {
            Console.WriteLine("Przekręciłeś gałkę ale automat jest pusty");
        }

        public void Wydaj()
        {
            Console.WriteLine("Nie wydano gumy");
        }
    }
}
