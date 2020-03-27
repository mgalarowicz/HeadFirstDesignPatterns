using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.MenuObiadowe
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
