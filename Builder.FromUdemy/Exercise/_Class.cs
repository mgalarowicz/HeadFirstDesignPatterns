using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.Exercise
{
    public class _Class
    {
        public string Name;
        public List<Field> Fields = new List<Field>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}").AppendLine("{");
            foreach (var f in Fields)
                sb.AppendLine($"  {f};");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
