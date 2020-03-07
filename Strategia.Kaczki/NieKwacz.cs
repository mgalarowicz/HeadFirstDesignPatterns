using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia.Kaczki
{
    public class NieKwacz : IKwakanie
    {
        public void Kwacz()
        {
            Console.WriteLine("<<<CISZA>>>");
        }
    }
}
