using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class PtakiIterator : IIterator
    {
        private readonly ArrayList _elementy;
        int _pozycja;

        public PtakiIterator(ArrayList elementy)
        {
            _elementy = elementy;
        }

        public bool HasNext() => !(_pozycja >= _elementy.Count || _elementy[_pozycja] == null);

        public object Next()
        {
            IKwacząca ptak = (IKwacząca)_elementy[_pozycja];
            _pozycja += 1;

            return ptak;
        }
    }
}
