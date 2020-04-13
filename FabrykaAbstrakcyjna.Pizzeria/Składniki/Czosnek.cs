using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Składniki
{
    public class Czosnek : IWarzywa
    {
        public string Opis => $"{nameof(Czosnek)}";
    }
}
