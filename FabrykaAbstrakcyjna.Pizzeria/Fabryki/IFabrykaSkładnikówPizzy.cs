using System;
using System.Collections.Generic;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Fabryki
{
    public interface IFabrykaSkładnikówPizzy
    {
        ICiasto UtwórzCiasto();
        ISos UtwórzSos();
        ISer UtwórzSer();
        IWarzywa[] UtwórzWarzywa();
        IPepperoni UtwórzPepperoni();
        IMałże UtwórzMałże();
    }
}
