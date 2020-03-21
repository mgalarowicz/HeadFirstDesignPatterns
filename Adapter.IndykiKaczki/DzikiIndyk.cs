using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.IndykiKaczki
{
    public class DzikiIndyk : IIndyk
    {
        public void Gulgocz()
        {
            Console.WriteLine("Gulgulgul!");
        }

        public void Lataj()
        {
            Console.WriteLine("O rany! Latam!... ale tylko w krótkich dystansach!");
        }
    }
}
