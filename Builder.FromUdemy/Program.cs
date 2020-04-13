using System;
using System.Text;
using Builder.FromUdemy.Builder.Html;
using Builder.FromUdemy.Exercise;
using Builder.FromUdemy.FacetedBuilder;
using Builder.FromUdemy.FluentBuilderInheritance;

namespace Builder.FromUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------BUILDER.HTML-----");
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);


            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");    //FLUENT INTERFACE - allows to chain several calls by returning, a reference to object you working with (in this case HTMLBUILDER)
            Console.WriteLine(builder.ToString());

            Console.WriteLine();
            Console.WriteLine("------EXERCISE-----");
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("------FACETED BUILDER-----");
            var pb = new PersonBuilder();

            //we can use AddressBuilder and JobBuilder after each other because they both inherit from PersonBuilder
            Person person = pb
                .Lives.At("LStreet")
                .In("London")
                .WithPostcode("sw12ac")
                .Works.At("Fabric")
                .AsA("Engineer")
                .Earning(123000);

            Console.WriteLine(person);

            Console.WriteLine();
            Console.WriteLine("------FLUENT BUILDER INHERITANCE-----");
            var me = Person2.New.Called("marek").WorksAsA("develop").Build();
            Console.WriteLine(me);
        }
    }
}
