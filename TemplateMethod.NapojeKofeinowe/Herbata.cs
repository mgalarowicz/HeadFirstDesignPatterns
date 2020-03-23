using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.NapojeKofeinowe
{
    public class Herbata : NapójZKofeiną
    {
        public override void Zaparzanie()
        {
            Console.WriteLine("Wkładanie torebki herbaty do wrzątku");
        }

        public override void DomieszanieDodatków()
        {
            Console.WriteLine("Dodanie cytryny");
        }

        public override bool CzyKlientChceDodatki()
        {
            string odp = PobierzOdpowiedź();

            return odp.ToLower().StartsWith("t");
        }

        private string PobierzOdpowiedź()
        {
            string odpowiedź = string.Empty;

            Console.WriteLine("Czy życzą sobie Państwo cytryny do Herbaty (t/n)? ");
            try
            {
                odpowiedź = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd wejścia-wyjścia podczas odczytywania odpowiedzi");
            }
            return odpowiedź;
        }
    }
}
