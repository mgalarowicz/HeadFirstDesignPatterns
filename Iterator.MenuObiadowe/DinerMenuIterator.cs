using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class DinerMenuIterator : IIterator
    {
        private readonly PozycjaMenu[] _elementy;
        int pozycja = 0;

        public DinerMenuIterator(PozycjaMenu[] elementy)
        {
            _elementy = elementy;
        }

        public bool HasNext() => !(pozycja >= _elementy.Length || _elementy[pozycja] == null);

        public object Next()
        {
            PozycjaMenu pozycjaMenu = _elementy[pozycja];
            pozycja += 1;

            return pozycjaMenu;
        }

        //public void Remove()
        //{
        //    if (pozycja <= 0)
        //        Console.WriteLine("Nie możesz usunąć elementu przed pierwszym wywołaniem metody next()");

        //    if (_elementy[pozycja-1] != null)
        //    {
        //        for (int i = pozycja-1; i < (_elementy.Length-1); i++)
        //        {
        //            _elementy[i] = _elementy[i+1];
        //        }
        //        _elementy[_elementy.Length-1] = null;
        //    }
        //}
    }
}
