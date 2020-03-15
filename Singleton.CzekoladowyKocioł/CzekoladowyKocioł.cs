//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Singleton.CzekoladowyKocioł
//{
//    public class CzekoladowyKocioł
//    {
//        private bool pusty;
//        private bool ugotowany;
        
//        //PRYWATNY KONSTRUKTOR
//        private CzekoladowyKocioł() { }


//        //OPOZNIONE TWORZENIE OBIEKTU
//        public static CzekoladowyKocioł unikalnaInstancja;

//        public static CzekoladowyKocioł PobierzInstancje()
//        {
//            if (unikalnaInstancja == null)
//            {
//                unikalnaInstancja = new CzekoladowyKocioł();
//            }
//            return unikalnaInstancja;
//        }

//        //WCZESNE TWORZENIE OBIEKTU (dobre przy wielowątkowości i gdy wiemy ze zawsze bedziemy potrzebowac instancji)
//        public static CzekoladowyKocioł unikalnaInstancja = new CzekoladowyKocioł();

//        public static CzekoladowyKocioł PobierzInstancje() => unikalnaInstancja;




//        public void Napełniaj()
//        {
//            if (JestPusty())
//            {
//                pusty = false;
//                ugotowany = false;
//            }
//        }

//        public void Opróżniaj()
//        {
//            if (!JestPusty() && JestUgotowany())
//            {
//                pusty = true;
//            }
//        }

//        public void Gotuj()
//        {
//            if (!JestPusty() && !JestUgotowany())
//            {
//                ugotowany = true;
//            }
//        }

//        public bool JestPusty() => pusty;

//        public bool JestUgotowany() => ugotowany;
//    }
//}
