using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public abstract class Napój
    {
        protected string opis = "Napój nieznany";

        public virtual string PobierzOpis() => opis;

        public abstract double Koszt();
    }
}
