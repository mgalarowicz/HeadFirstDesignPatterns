using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka.Pizzeria
{
    public abstract class Pizza
    {
        protected string nazwa;
        protected string ciasto;
        protected string sos;
        protected List<string> dodatki = new List<string>();

        public void Przygotowanie()
        {
            Console.WriteLine("Przygotowanie: " + nazwa);
            Console.WriteLine("Wyrabianie ciasta...");
            Console.WriteLine("Dodawanie sosu...");
            Console.WriteLine("Dodatki: ");

            for (int i = 0; i < dodatki.Count; i++)
            {
                Console.WriteLine(" " + dodatki[i]);
            }
        }

        public void Pieczenie()
        {
            Console.WriteLine("Pieczenie: 25 minut w temperaturze 350 stopni Celsjusza");
        }

        public virtual void Krojenie()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawałków");
        }

        public void Pakowanie()
        {
            Console.WriteLine("Pakowanie pizzy w oficjalne pudełko naszej sieci Pizzerii :)");
        }

        public string PobierzNazwa() => nazwa;
    }
}
