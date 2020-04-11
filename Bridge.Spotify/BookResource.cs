using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public class BookResource : IResource
    {
        private readonly Book _book;

        public BookResource(Book book)
        {
            _book = book;
        }

        public string Snippet() => _book.Info();


        public string Title() => _book.Title;


        public string Url() => _book.Address;

    }
}
