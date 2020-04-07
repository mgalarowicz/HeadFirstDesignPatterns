using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.BookParser
{
    public class BookParser : IBookParser
    {
        private int _numOfPages;

        public BookParser(string book)
        {
            //expensive parsing
            _numOfPages = 1;
        }

        public int GetNumberOfPages() => _numOfPages;
    }
}
