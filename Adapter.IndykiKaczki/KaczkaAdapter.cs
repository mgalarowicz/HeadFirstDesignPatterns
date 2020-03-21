using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.IndykiKaczki
{
    public class KaczkaAdapter : IIndyk
    {
        private readonly IKaczka _kaczka;
        private Random _rand;

        public KaczkaAdapter(IKaczka kaczka)
        {
            _kaczka = kaczka;
            _rand = new Random();
        }

        public void Gulgocz()
        {
            _kaczka.Kwacz();
        }

        public void Lataj()
        {
            if (_rand.Next(5) == 0)
                _kaczka.Lataj();
        }
    }
}
