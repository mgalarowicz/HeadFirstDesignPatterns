using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public class WarunkiBiezaceWyswietl : IObserwator, IWyswietlElement
    {
        private float temperatura;
        private float wilgotnosc;
        private IPodmiot _danePogodowe;

        public WarunkiBiezaceWyswietl(IPodmiot danePogodowe)
        {
            _danePogodowe = danePogodowe;
            _danePogodowe.ZarejestrujObserwatora(this);
        }

        public void Aktualizacja(float temp, float wilgotnosc, float cisnienie)
        {
            this.temperatura = temp;
            this.wilgotnosc = wilgotnosc;
            Wyswietl();
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Warunki bieżące {temperatura} stopni C oraz {wilgotnosc} % wilgotnosc");
        }
    }
}
