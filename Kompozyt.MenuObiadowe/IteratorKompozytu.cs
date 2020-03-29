using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public class IteratorKompozytu : IIterator
    {
        Stack<IIterator> stos = new Stack<IIterator>();

        public IteratorKompozytu(IIterator iterator)
        {
            stos.Push(iterator);
        }

        public bool HasNext()
        {
            if (stos.Count == 0)
                return false;


            IIterator iterator = (IIterator)stos.Peek();
            if (!iterator.HasNext())
            {
                stos.Pop();
                return HasNext();
            }

            return true;
        }

        public object Next()
        {
            if (HasNext())
            {
                IIterator iterator = (IIterator)stos.Peek();
                MenuSkładnik składnik = (MenuSkładnik)iterator.Next();
                
                if(składnik is Menu)
                {
                    stos.Push(składnik.UtwórzIterator());
                }
                return składnik;
            }

            return null;
        }
    }
}
