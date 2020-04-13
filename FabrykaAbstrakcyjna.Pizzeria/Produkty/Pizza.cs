using System;
using System.Text;
using FabrykaAbstrakcyjna.Pizzeria.Abstrakcje;

namespace FabrykaAbstrakcyjna.Pizzeria.Produkty
{
    public abstract class Pizza
    {
        protected string nazwa;
        protected ICiasto ciasto;
        protected ISos sos;
        protected IWarzywa[] warzywa;
        protected ISer ser;
        protected IPepperoni pepperoni;
        protected IMałże małże;

        public abstract void Przygotowanie();

        public void Pieczenie()
        {
            Console.WriteLine("Pieczenie: 25 minut w temperaturze 350 stopni Celsjusza");
        }

        public virtual void Krojenie()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawałków");
        }

        public void Pakowanie()
        {
            Console.WriteLine("Pakowanie pizzy w oficjalne pudełko naszej sieci Pizzerii :)");
        }

        public string UstawNazwa(string nazwa) => this.nazwa = nazwa;

        public string PobierzNazwa() => nazwa;

        public override string ToString()
        {
			StringBuilder result = new StringBuilder();
            result.Append("---- " + nazwa + " ----\n");
            if (ciasto != null)
            {
                result.Append(ciasto.Opis);
                result.Append("\n");
            }
            if (sos != null)
            {
                result.Append(sos.Opis);
                result.Append("\n");
            }
            if (ser != null)
            {
                result.Append(ser.Opis);
                result.Append("\n");
            }
            if (warzywa != null)
            {
                for (int i = 0; i < warzywa.Length; i++)
                {
                    result.Append(warzywa[i].Opis);
                    if (i < warzywa.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (małże != null)
            {
                result.Append(małże.Opis);
                result.Append("\n");
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni.Opis);
                result.Append("\n");
            }
            return result.ToString();
		}
    }
}
