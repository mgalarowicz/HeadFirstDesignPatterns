using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FluentBuilderInheritance
{
    //stick it as generic argument calling itself because it's a self referential relationship effectively 
    public class PersonInfoBuilder<SELF> : PersonBuilder2 where SELF : PersonInfoBuilder<SELF>   //class Foo : Bar<Foo> - restricting SELF.
    //It's allowed when SELF actually refers to object inheriting from this object
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;       //has to return this which is going through inheritance
        }
    }
}
