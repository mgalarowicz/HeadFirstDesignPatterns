using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FluentBuilderInheritance
{
    public class PersonBuilder2
    {
        protected Person2 person = new Person2();

        public Person2 Build()
        {
            return person;
        }
    }
}
