using System;

namespace TemplateMethod.NapojeKofeinowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Herbata herbata = new Herbata();
            Kawa kawa = new Kawa();

            Console.WriteLine("\nPrzyrządzam wspaniałą, gorącą herbatę...");
            herbata.RecepturaParzenia();

            Console.WriteLine("\nA teraz pora na gorącą, aromatyczną kawę...");
            kawa.RecepturaParzenia();
        }
    }
}
