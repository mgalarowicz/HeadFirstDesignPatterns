using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public class Book
    {
        public string Title => "Something";

        public string Info()
        {
            var author = "J.K.Rowling";
            var description = "something cool";
            var price = 14;

            return $"Great book writen by {author}. Book is about {description}, and it cost only {price}";
        }

        public string Address => "https://www.CoolBook.com";
    }
}
