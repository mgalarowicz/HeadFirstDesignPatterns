using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly ArrayList _elementy;
        int pozycja;

        public PancakeHouseMenuIterator(ArrayList elementy)
        {
            _elementy = elementy;
        }

        public bool HasNext() => !(pozycja >= _elementy.Count || _elementy[pozycja] == null);

        public object Next()
        {
            PozycjaMenu pozycjaMenu = (PozycjaMenu)_elementy[pozycja];
            pozycja += 1;

            return pozycjaMenu;
        }
    }
}
