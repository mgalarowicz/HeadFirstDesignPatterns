using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;
using FabrykaAbstrakcyjna.Pizzeria.Fabryki;
using FabrykaAbstrakcyjna.Pizzeria.Składniki;

namespace Fabryka.Pizzeria.Składniki
{
    public class AmerykańskaFabrykaSkładnikówPizzy : IFabrykaSkładnikówPizzy
    {
        public ICiasto UtwórzCiasto()
        {
            return new GrubeChrupkieCiasto();
        }

        public ISos UtwórzSos()
        {
            return new SosPomidorowy();
        }

        public ISer UtwórzSer()
        {
            return new SerMozzarella();
        }

        public IWarzywa[] UtwórzWarzywa()
        {
            IWarzywa[] warzywa = {
                new Bakłażan(), new Szpinak(),
                new CzarneOliwki()
            };

            return warzywa;
        }

        public IPepperoni UtwórzPepperoni()
        {
            return new PlastryPepperoni();
        }

        public IMałże UtwórzMałże()
        {
            return new MrożoneMałże();
        }
    }
}
