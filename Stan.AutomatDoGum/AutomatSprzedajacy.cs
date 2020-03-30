using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public enum StanAutomatu
    {
        BRAK_GUM = 0,
        NIE_MA_MONETY,
        JEST_MONETA,
        GUMA_SPRZEDANA
    }

    public class AutomatSprzedajacy
    {
        private int _liczba;
        private StanAutomatu stan = StanAutomatu.BRAK_GUM;

        public AutomatSprzedajacy(int liczba)
        {
            _liczba = liczba;
            if (liczba > 0)
            {
                stan = StanAutomatu.NIE_MA_MONETY;
            }
        }

        public void WłóżMonetę()
        {
            switch (stan)
            {
                case StanAutomatu.JEST_MONETA:
                    Console.WriteLine("Nie możesz włożyć więcej niż jednej monety");
                    break;
                case StanAutomatu.NIE_MA_MONETY:
                    stan = StanAutomatu.JEST_MONETA;
                    Console.WriteLine("Moneta przyjęta");
                    break;
                case StanAutomatu.BRAK_GUM:
                    Console.WriteLine("Nie możesz włożyć monety, gdy automat jest pusty");
                    break;
                case StanAutomatu.GUMA_SPRZEDANA:
                    Console.WriteLine("Proszę czekać na gumę");
                    break;
            }
        }

        public void ZwróćMonetę()
        {
            switch (stan)
            {
                case StanAutomatu.JEST_MONETA:
                    Console.WriteLine("Moneta zwrócona");
                    stan = StanAutomatu.NIE_MA_MONETY;
                    break;
                case StanAutomatu.NIE_MA_MONETY:
                    Console.WriteLine("Nie włożyłeś monety");
                    break;
                case StanAutomatu.BRAK_GUM:
                    Console.WriteLine("Nie włożyłeś monety");
                    break;
                case StanAutomatu.GUMA_SPRZEDANA:
                    Console.WriteLine("Niestety, nie można zwrócić monety po przekręceniu gałki");
                    break;
            }
        }

        public void PrzekręćGałkę()
        {
            switch (stan)
            {
                case StanAutomatu.JEST_MONETA:
                    Console.WriteLine("Obróciłeś gałkę...");
                    stan = StanAutomatu.GUMA_SPRZEDANA;
                    Wydaj();
                    break;
                case StanAutomatu.NIE_MA_MONETY:
                    Console.WriteLine("Zanim przekręcisz gałkę, wrzuć monetę");
                    break;
                case StanAutomatu.BRAK_GUM:
                    Console.WriteLine("Przekręciłeś gałkę ale automat jest pusty");
                    break;
                case StanAutomatu.GUMA_SPRZEDANA:
                    Console.WriteLine("Nie dostaniesz gumy tylko dlatego, że przekręciłeś drugi raz!");
                    break;
            }
        }

        public void Wydaj()
        {
            switch (stan)
            {
                case StanAutomatu.JEST_MONETA:
                    Console.WriteLine("Nie wydano gumy");
                    break;
                case StanAutomatu.NIE_MA_MONETY:
                    Console.WriteLine("Najpierw zapłać");
                    break;
                case StanAutomatu.BRAK_GUM:
                    Console.WriteLine("PNie wydano gumy");
                    break;
                case StanAutomatu.GUMA_SPRZEDANA:
                    Console.WriteLine("Wypada guma");
                    _liczba -= 1;
                    if (_liczba == 0)
                    {
                        Console.WriteLine("Ups, koniec gum!");
                        stan = StanAutomatu.BRAK_GUM;
                    }
                    else
                    {
                        stan = StanAutomatu.NIE_MA_MONETY;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append("Automaty sprzedające SA");
            sb.Append("\nWolnostojący automat sprzedający Gumball Model #2004 C#");
            sb.Append($"\nZapas: {_liczba}");


            if (_liczba > 0)
                sb.Append("\nAutomat oczekuje na monetę");
            else
                sb.Append("\nAutomat jest pusty");

            sb.AppendLine();

            return sb.ToString();
        }
    }
}
