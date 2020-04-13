using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FluentBuilderInheritance
{
    //Builders inherit from other builder
    //Recursive Generics - approach to get fluent interfaces inherit
    public class Person2
    {
        public string Name;

        public string Position;

        public class Builder : PersonJobBuilder2<Builder>   //Recursive Generics Approach  - passing a Type as a Generic argument
        {

        }

        public static Builder New => new Builder();  //public property to expose Builder

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
