using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern.Kaczki
{
    public abstract class AbstrakcyjnaFabrykaKaczek
    {
        public abstract IKwacząca UtwórzDzikaKaczka();
        public abstract IKwacząca UtwórzPłaskonosKaczka();
        public abstract IKwacząca UtwórzWabikKaczka();
        public abstract IKwacząca UtwórzGumowaKaczka();
    }
}
