using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public class PrognozaWyswietl : IObserwator, IWyswietlElement
    {
        private float aktualneCisnienie = 29.9f;
        private float ostatnieCisnienie;
        private IPodmiot _danePogodowe;

        public PrognozaWyswietl(IPodmiot danePogodowe)
        {
            _danePogodowe = danePogodowe;
            _danePogodowe.ZarejestrujObserwatora(this);
        }

        public void Aktualizacja(float temp, float wilgotnosc, float cisnienie)
        {
            ostatnieCisnienie = aktualneCisnienie;
            aktualneCisnienie = cisnienie;
            Wyswietl();
        }

        public void Wyswietl()
        {
            Console.WriteLine("Pogoda: ");
            if (ostatnieCisnienie < aktualneCisnienie)
            {
                Console.WriteLine("Nadchodzi poprawa pogody!");
            }
            else if (Math.Abs(ostatnieCisnienie - aktualneCisnienie) < 1)
            {
                Console.WriteLine("Pogoda bez zmian");
            }
            else if (ostatnieCisnienie > aktualneCisnienie)
            {
                Console.WriteLine("Uwaga, bedzie pogorszenie pogody!");
            }
        }
    }
}
