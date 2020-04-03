using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class FabrykaKaczek : AbstrakcyjnaFabrykaKaczek
    {
        public override IKwacząca UtwórzDzikaKaczka() => new DzikaKaczka();

        public override IKwacząca UtwórzPłaskonosKaczka() => new PłaskonosKaczka();

        public override IKwacząca UtwórzWabikKaczka() => new WabikKaczka();

        public override IKwacząca UtwórzGumowaKaczka() => new GumowaKaczka();

    }
}
