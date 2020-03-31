using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class StanJestMoneta : IStan
    {
        private readonly AutomatSprzedajacy _automatSprzedajacy;
        Random _losowaWygrana = new Random();

        public StanJestMoneta(AutomatSprzedajacy automatSprzedajacy)
        {
            _automatSprzedajacy = automatSprzedajacy;
        }

        public void WłóżMonetę()
        {
            Console.WriteLine("Nie możesz włożyć więcej niż jednej monety");
        }

        public void ZwróćMonetę()
        {
            Console.WriteLine("Moneta zwrócona");
            _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanNieMaMonety());
        }

        public void PrzekręćGałkę()
        {
            Console.WriteLine("Obróciłeś gałkę...");
            int wygrana = _losowaWygrana.Next(10);
            if (wygrana == 0)
            {
                _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanWygrana());
            }
            else
            {  
                _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanGumaSprzedana());
            }
        }

        public void Wydaj()
        {
            Console.WriteLine("Nie wydano gumy");
        }
    }
}
