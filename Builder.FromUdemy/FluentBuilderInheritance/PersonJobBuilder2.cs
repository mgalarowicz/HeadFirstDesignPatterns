using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FluentBuilderInheritance
{
    public class PersonJobBuilder2<SELF> : PersonInfoBuilder<PersonJobBuilder2<SELF>> where SELF : PersonJobBuilder2<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
