using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Składniki
{
    public class SosMarinara : ISos
    {
        public string Opis => $"{nameof(SosMarinara)}";
    }
}
