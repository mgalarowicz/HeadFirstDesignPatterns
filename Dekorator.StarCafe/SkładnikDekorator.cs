using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public abstract class SkładnikDekorator : Napój
    {
        public abstract override string PobierzOpis();
        public abstract override Wielkość PobierzWielkość();
    }
}
