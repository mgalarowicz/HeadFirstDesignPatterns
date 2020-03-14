//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Fabryka.Pizzeria.WariantZeSkładnikami
//{
//    public abstract class Pizza_
//    {
//        protected string nazwa;
//        protected Ciasto ciasto;
//        protected Sos sos;
//        protected Warzywa[] warzywa;
//        protected Ser ser;
//        protected Pepperoni pepperoni;
//        protected Małże małże;

//        public abstract void Przygotowanie();

//        public void Pieczenie()
//        {
//            Console.WriteLine("Pieczenie: 25 minut w temperaturze 350 stopni Celsjusza");
//        }

//        public virtual void Krojenie()
//        {
//            Console.WriteLine("Krojenie pizzy na 8 kawałków");
//        }

//        public void Pakowanie()
//        {
//            Console.WriteLine("Pakowanie pizzy w oficjalne pudełko naszej sieci Pizzerii :)");
//        }

//        public string UstawNazwa(string nazwa) => this.nazwa = nazwa;

//        public string PobierzNazwa() => nazwa;
//    }
//}
