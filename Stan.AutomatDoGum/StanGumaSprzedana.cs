using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class StanGumaSprzedana : IStan
    {
        private readonly AutomatSprzedajacy _automatSprzedajacy;

        public StanGumaSprzedana(AutomatSprzedajacy automatSprzedajacy)
        {
            _automatSprzedajacy = automatSprzedajacy;
        }

        public void WłóżMonetę()
        {
            Console.WriteLine("Proszę czekać na gumę");
        }

        public void ZwróćMonetę()
        {
            Console.WriteLine("Niestety, nie można zwrócić monety po przekręceniu gałki");
        }

        public void PrzekręćGałkę()
        {
            Console.WriteLine("Nie dostaniesz gumy tylko dlatego, że przekręciłeś drugi raz!");
        }

        public void Wydaj()
        {
            var _liczba = _automatSprzedajacy.GetLiczba();

            _automatSprzedajacy.ZwolnijGumę();

            if (_liczba == 0)
            {
                Console.WriteLine("Ups, koniec gum!");
                _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanBrakGum());
            }
            else
            {
                _automatSprzedajacy.UstawStan(_automatSprzedajacy.GetStanNieMaMonety());
            }
        }
    }
}
