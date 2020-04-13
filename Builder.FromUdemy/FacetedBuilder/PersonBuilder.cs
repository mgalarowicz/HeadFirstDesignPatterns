using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FacetedBuilder
{
    public class PersonBuilder //facade - component that hides a lot of information behind it
    {
        //reference!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        //writeline showing a person
        public static implicit operator Person(PersonBuilder pb)    //implicit conversion operator to person
        {
            return pb.person;
        }
    }
}
