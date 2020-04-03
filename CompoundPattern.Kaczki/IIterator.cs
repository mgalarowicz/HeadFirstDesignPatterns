using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
