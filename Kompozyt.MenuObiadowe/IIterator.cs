using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
