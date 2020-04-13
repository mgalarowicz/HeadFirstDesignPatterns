using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Składniki
{
    public class SerReggiano : ISer
    {
        public string Opis => $"{nameof(SerReggiano)}";
    }
}
