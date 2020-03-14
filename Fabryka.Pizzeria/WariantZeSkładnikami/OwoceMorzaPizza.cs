//using System;
//using System.Collections.Generic;
//using System.Text;
//using Fabryka.Pizzeria.Składniki;

//namespace Fabryka.Pizzeria.WariantZeSkładnikami
//{
//    public class OwoceMorzaPizza : Pizza_
//    {
//        IFabrykaSkładnikówPizzy fabrykaSkladnikow;

//        public OwoceMorzaPizza(IFabrykaSkładnikówPizzy fabrykaSkladnikow)
//        {
//            this.fabrykaSkladnikow = fabrykaSkladnikow;
//        }
//        public override void Przygotowanie()
//        {
//            Console.WriteLine($"Przygotowanie: {nazwa}");
//            ciasto = fabrykaSkladnikow.UtwórzCiasto();
//            sos = fabrykaSkladnikow.UtwórzSos();
//            ser = fabrykaSkladnikow.UtwórzSer();
//        }
//    }
//}
