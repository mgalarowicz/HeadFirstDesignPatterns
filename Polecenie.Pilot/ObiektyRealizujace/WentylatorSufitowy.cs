using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie.Pilot.ObiektyRealizujace
{
    
    public enum Obroty
    {
        Wysokie = 30,
        Średnie = 20,
        Niskie = 10,
        Wyłączony = 0
    }

    public class WentylatorSufitowy
    {
        private readonly string _pomieszczenie;
        private Obroty _speed;

        public WentylatorSufitowy(string pomieszczenie)
        {
            _pomieszczenie = pomieszczenie;
            _speed = Obroty.Wyłączony;
        }

        public void WysokieObroty()
        {   
            _speed = Obroty.Wysokie;
            Console.WriteLine($"Wentylator ustawiony na wysokie obroty w {_pomieszczenie}");
        }

        public void ŚrednieObroty()
        {
            _speed = Obroty.Średnie;
            Console.WriteLine($"Wentylator ustawiony na średnie obroty w {_pomieszczenie}");
        }

        public void NiskieObroty()
        {
            _speed = Obroty.Niskie;
            Console.WriteLine($"Wentylator ustawiony na niskie obroty w {_pomieszczenie}");
        }

        public void Wyłącz()
        {
            _speed = (int)Obroty.Wyłączony;
            Console.WriteLine($"Wentylator wyłączony w {_pomieszczenie}");
        }

        public Obroty PobierzPrędkość() => _speed;
    }
}
