using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.Exercise
{
    public class CodeBuilder
    {
        private _Class theClass;

        public CodeBuilder(string rootName)
        {
            theClass = new _Class();
            theClass.Name = rootName;
        }

        public CodeBuilder AddField(string name, string type)
        {
            theClass.Fields.Add(new Field { Name = name, Type = type });
            return this;
        }

        public override string ToString()
        {
            return theClass.ToString();
        }
    }
}
