using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.BookParser
{
    public class LazyBookParserProxy : IBookParser
    {
        private string _book;
        private BookParser _bookParser;

        public LazyBookParserProxy(string book)
        {
            _book = book;
        }

        public int GetNumberOfPages()
        {
            if (_bookParser == null)
                _bookParser = new BookParser(_book);

            return _bookParser.GetNumberOfPages();
        }
    }
}
