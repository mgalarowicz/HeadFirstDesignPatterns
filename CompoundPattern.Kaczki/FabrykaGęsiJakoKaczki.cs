using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class FabrykaGęsiJakoKaczki : AbstrakcyjnaFabrykaGęsi
    {
        public override IKwacząca UtwórzGęś() => new GęśAdapter(new Gęś());
    }
}
