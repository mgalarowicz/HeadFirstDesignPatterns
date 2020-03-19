using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    public class WentylatorSufitowy
    {
        private readonly string _pomieszczenie;
        private int _speed = 0;

        public WentylatorSufitowy(string pomieszczenie)
        {
            _pomieszczenie = pomieszczenie;
        }

        public void WysokieObroty()
        {   
            _speed = 20;
            Console.WriteLine($"Wentylator ustawiony na wysokie obroty w {_pomieszczenie}");
        }

        public void ŚrednieObroty()
        {
            _speed = 10;
            Console.WriteLine($"Wentylator ustawiony na średnie obroty w {_pomieszczenie}");
        }

        public void NiskieObroty()
        {
            _speed = 5;
            Console.WriteLine($"Wentylator ustawiony na niskie obroty w {_pomieszczenie}");
        }

        public void Wyłącz()
        {
            Console.WriteLine($"Wentylator wyłączony w {_pomieszczenie}");
        }

        public void PobierzPrędkość()
        {
            Console.WriteLine($"Prędkość wentylatora w {_pomieszczenie} wynosi: {_speed}");
        }
    }
}
