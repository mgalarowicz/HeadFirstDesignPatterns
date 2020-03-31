using System;
using System.Collections.Generic;
using System.Text;

namespace Stan.AutomatDoGum
{
    public class AutomatSprzedajacy
    {
        
        private IStan _stanBrakGum;
        private IStan _stanNieMaMonety;
        private IStan _stanJestMoneta;
        private IStan _stanGumaSprzedana;
        private IStan _stanWygrana;
        private int _liczba;
        private IStan _stan;

        public AutomatSprzedajacy(int liczba)
        {
            _stanBrakGum = new StanBrakGum(this);
            _stanNieMaMonety = new StanNieMaMonety(this);
            _stanJestMoneta = new StanJestMoneta(this);
            _stanGumaSprzedana = new StanGumaSprzedana(this);

            _liczba = liczba;
            if (liczba > 0)
                _stan = _stanNieMaMonety;
            else
                _stan = _stanBrakGum;
            
        }

        public void WłóżMonetę()
        {
           _stan.WłóżMonetę();
        }

        public void ZwróćMonetę()
        {
            _stan.ZwróćMonetę();
        }

        public void PrzekręćGałkę()
        {
           _stan.PrzekręćGałkę();
           _stan.Wydaj();
        }

        public IStan GetStanJestMoneta() => _stanJestMoneta;
        public IStan GetStanNieMaMonety() => _stanNieMaMonety;
        public IStan GetStanBrakGum() => _stanBrakGum;
        public IStan GetStanGumaSprzedana() => _stanGumaSprzedana;
        public IStan GetStanWygrana() => _stanWygrana;

        public void UstawStan(IStan stan)
        {
            _stan = stan;
        }

        public void ZwolnijGumę()
        {
            if (_liczba > 0)
            {
                Console.WriteLine("Wypada guma...");
                _liczba -= 1;
            }
        }

        public void Napełnij(int liczba)
        {
            _liczba = liczba;
            _stan = _stanNieMaMonety;
        }

        public int GetLiczba() => _liczba;
        
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
