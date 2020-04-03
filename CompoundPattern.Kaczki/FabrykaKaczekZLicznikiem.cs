using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public class FabrykaKaczekZLicznikiem : AbstrakcyjnaFabrykaKaczek
    {
        public override IKwacząca UtwórzDzikaKaczka() => new KwakLicznik(new DzikaKaczka());
        
        public override IKwacząca UtwórzPłaskonosKaczka() => new KwakLicznik(new PłaskonosKaczka());
        
        public override IKwacząca UtwórzWabikKaczka() => new KwakLicznik(new WabikKaczka());
        
        public override IKwacząca UtwórzGumowaKaczka() => new KwakLicznik(new GumowaKaczka());
    }
}
