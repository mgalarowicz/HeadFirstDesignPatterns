using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia.Kaczki
{
    public class Wabik
    {
        protected IKwakanie kwakanieInterfejs;

        public void WykonajKwacz()
        {
            kwakanieInterfejs.Kwacz();
        }

        public void UstawKwakanie(IKwakanie ki)
        {
            kwakanieInterfejs = ki;
        }
    }
}
