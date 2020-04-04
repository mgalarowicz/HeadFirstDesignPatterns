using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class ObserwatorzyIterator : IIterator
    {
        private readonly ArrayList _elementy;
        private int _pozycja;

        public ObserwatorzyIterator(ArrayList elementy)
        {
            _elementy = elementy;
        }

        public bool HasNext() => !(_pozycja >= _elementy.Count || _elementy[_pozycja] == null);

        public object Next()
        {
            IObserwator obserwator = (IObserwator)_elementy[_pozycja];
            _pozycja += 1;

            return obserwator;
        }
    }
}
