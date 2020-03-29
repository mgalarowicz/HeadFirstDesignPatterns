using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public class IteratorPusty : IIterator
    {
        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return false;
        }
    }
}
