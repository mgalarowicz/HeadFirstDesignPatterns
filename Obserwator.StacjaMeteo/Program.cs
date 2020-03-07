using System;

namespace Obserwator.StacjaMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            DanePogodowe danePogodowe = new DanePogodowe();

            WarunkiBiezaceWyswietl warunkiBiezaceWyswietl = new WarunkiBiezaceWyswietl(danePogodowe);
            PrognozaWyswietl prognozaWyswietl = new PrognozaWyswietl(danePogodowe);
            IndexCiepla indexCiepla = new IndexCiepla(danePogodowe);

            danePogodowe.UstawOdczyty(26.6f, 65, 1013.1f);
            danePogodowe.UstawOdczyty(27.7f, 70, 997.0f);
            danePogodowe.UstawOdczyty(25.5f, 90, 997.0f);
        }
    }
}
