using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;
using FabrykaAbstrakcyjna.Pizzeria.Składniki;

namespace FabrykaAbstrakcyjna.Pizzeria.Fabryki
{
    public class WłoskaFabrykaSkładnikówPizzy : IFabrykaSkładnikówPizzy
    {
        public ICiasto UtwórzCiasto()
        {
            return new CienkieChrupkieCiasto();
        }

        public ISos UtwórzSos()
        {
            return new SosMarinara();
        }

        public ISer UtwórzSer()
        {
            return new SerReggiano();
        }

        public IWarzywa[] UtwórzWarzywa()
        {
            IWarzywa[] warzywa = {new Czosnek(), new Cebula(),
                                                new Pieczarki(), new CzerwonaPapryka()};
            return warzywa;
        }

        public IPepperoni UtwórzPepperoni()
        {
            return new PlastryPepperoni();
        }

        public IMałże UtwórzMałże()
        {
            return new ŚwieżeMałże();
        }
    }
}
