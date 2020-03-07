using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia.Kaczki
{
    public abstract class Kaczka
    {
        protected ILatanie latanieInterfejs;
        protected IKwakanie kwakanieInterfejs;

        public abstract void Wyświetl();

        public void WykonajLeć()
        {
            latanieInterfejs.Leć();
        }

        public void WykonajKwacz()
        {
            kwakanieInterfejs.Kwacz();
        }

        public void Pływaj()
        {
            Console.WriteLine("Wszystkie kaczki pływają, nawet te sztuczne!");
        }

        public void UstawLatanie(ILatanie li)
        {
            latanieInterfejs = li;
        }

        public void UstawKwakanie(IKwakanie ki)
        {
            kwakanieInterfejs = ki;
        }
    }
}
