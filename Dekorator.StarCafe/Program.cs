using System;

namespace Dekorator.StarCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Napój napój = new Espresso();
            Console.WriteLine(napój.PobierzOpis() + " " + napój.Koszt() + " zł");

            Napój napój2 = new MocnoPalona();
            napój2 = new Czekolada(napój2);
            napój2 = new Czekolada(napój2);
            napój2 = new BitaŚmietana(napój2);
            Console.WriteLine(napój2.PobierzOpis() + " " + napój2.Koszt() + " zł");

            Napój napój3 = new StarCafeSpecial();
            napój3 = new MleczkoSojowe(napój3);
            napój3 = new Czekolada(napój3);
            napój3 = new BitaŚmietana(napój3);
            Console.WriteLine(napój3.PobierzOpis() + " " + napój3.Koszt() + " zł");
        }
    }
}
