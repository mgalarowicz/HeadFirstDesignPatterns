using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.StarCafe
{
    public abstract class Napój
    {
        protected string opis = "Napój nieznany";
        protected Wielkość wielkość = Wielkość.Średnia;

        public virtual string PobierzOpis() => opis;
        public virtual Wielkość PobierzWielkość() => wielkość;

        public abstract double Koszt();
        
        public void UstawWielkość(Wielkość wielkość)
        {
            this.wielkość = wielkość;
            opis = this.opis + ", " + wielkość.ToString();
        }
    }

    public enum Wielkość
    {
        Mała,
        Średnia,
        Duża
    }
}
