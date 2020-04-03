using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class GęśAdapter : IKwacząca
    {
        private readonly Gęś _gęś;

        public GęśAdapter(Gęś gęś)
        {
            _gęś = gęś;
        }

        public void Kwacz()
        {
            _gęś.Gęgaj();
        }
    }
}
