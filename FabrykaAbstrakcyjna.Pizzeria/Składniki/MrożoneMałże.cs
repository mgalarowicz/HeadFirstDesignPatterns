using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Składniki
{
    public class MrożoneMałże : IMałże
    {
        public string Opis => $"{nameof(MrożoneMałże)}";
    }
}
