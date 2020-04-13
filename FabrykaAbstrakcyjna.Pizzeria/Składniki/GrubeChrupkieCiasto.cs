using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Składniki
{
    public class GrubeChrupkieCiasto : ICiasto
    {
        public string Opis => $"{nameof(GrubeChrupkieCiasto)}";
    }
}
