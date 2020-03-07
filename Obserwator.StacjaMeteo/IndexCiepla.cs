using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator.StacjaMeteo
{
    public class IndexCiepla : IObserwator, IWyswietlElement
    {
        private float _temperatura;
        private float _wilgotnosc;
        private IPodmiot _danePogodowe;

        public IndexCiepla(IPodmiot danePogodowe)
        {
            _danePogodowe = danePogodowe;
            _danePogodowe.ZarejestrujObserwatora(this);
        }

        public void Aktualizacja(float temp, float wilgotnosc, float cisnienie)
        {
            _temperatura = temp;
            _wilgotnosc = wilgotnosc;
            Wyswietl();
        }

        public void Wyswietl()
        {
            var index = ObliczIndexCiepla(_temperatura, _wilgotnosc);
            Console.WriteLine($"Obliczony index ciepla: {index}");
        }

        private float ObliczIndexCiepla(float t, float rh)
        {
            return (float)
            (
                (16.923 + (0.185212 * t)) +
                (5.37941 * rh) -
                (0.100254 * t * rh) +
                (0.00941695 * (t * t)) +
                (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) -
                (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) -
                (0.000038646 * (t * t * t)) +
                (0.0000291583 * (rh * rh * rh)) +
                (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) -
                (0.0000000218429 * (t * t * t * rh * rh)) +
                (0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
        }
    }
}
