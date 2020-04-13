using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.Exercise
{
    public class Field
    {
        public string Type, Name;

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }
}
