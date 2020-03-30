using System;

namespace Stan.AutomatDoGum
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomatSprzedajacy automatSprzedajacy = new AutomatSprzedajacy(5);

            Console.WriteLine(automatSprzedajacy);

            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();

            Console.WriteLine(automatSprzedajacy);

            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.ZwróćMonetę();
            automatSprzedajacy.PrzekręćGałkę();

            Console.WriteLine(automatSprzedajacy);

            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();
            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();
            automatSprzedajacy.ZwróćMonetę();

            Console.WriteLine(automatSprzedajacy);

            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();
            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();
            automatSprzedajacy.WłóżMonetę();
            automatSprzedajacy.PrzekręćGałkę();

            Console.WriteLine(automatSprzedajacy);
        }
    }
}
