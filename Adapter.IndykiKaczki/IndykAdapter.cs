using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.IndykiKaczki
{
    public class IndykAdapter : IKaczka
    {
        private readonly IIndyk _indyk;

        public IndykAdapter(IIndyk indyk)
        {
            _indyk = indyk;
        }

        public void Kwacz()
        {
            _indyk.Gulgocz();
        }

        public void Lataj()
        {
            for (int i = 0; i < 5; i++)
            {
                _indyk.Lataj();
            }
        }
    }
}
