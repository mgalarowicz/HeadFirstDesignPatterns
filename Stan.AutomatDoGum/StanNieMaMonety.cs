using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class StanNieMaMonety : IStan
    {
        private readonly AutomatSprzedajacy _automatSprzedajacy;

        public StanNieMaMonety(AutomatSprzedajacy automatSprzedajacy)
        {
            _automatSprzedajacy = automatSprzedajacy;
        }

        public void WłóżMonetę()
        {
            Console.WriteLine("Moneta przyjęta");
            _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanJestMoneta());
        }

        public void ZwróćMonetę()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public void PrzekręćGałkę()
        {
            Console.WriteLine("Zanim przekręcisz gałkę, wrzuć monetę");
        }

        public void Wydaj()
        {
            Console.WriteLine("Najpierw zapłać");
        }
    }
}
