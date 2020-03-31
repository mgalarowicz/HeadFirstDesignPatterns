using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class StanWygrana : IStan
    {
        private readonly AutomatSprzedajacy _automatSprzedający;

        public StanWygrana(AutomatSprzedajacy automatSprzedający)
        {
            _automatSprzedający = automatSprzedający;
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
            Console.WriteLine("Wygrałeś! Dostajesz drugą gumę!");
            _automatSprzedający.ZwolnijGumę();
            if (_automatSprzedający.GetLiczba() == 0)
            {
                _automatSprzedający.UstawStan(_automatSprzedający.GetStanBrakGum());
            }
            else
            {
                _automatSprzedający.ZwolnijGumę();
                if (_automatSprzedający.GetLiczba() > 0)
                {
                    _automatSprzedający.UstawStan(_automatSprzedający.GetStanNieMaMonety());
                }
                else
                {
                    Console.WriteLine("Ups, koniec gum!");
                    _automatSprzedający.UstawStan(_automatSprzedający.GetStanBrakGum());
                }
            }
        }
    }
}
