using System;

namespace Bridge.Spotify
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            var artist = new Artist();

            var bookRes = new BookResource(book);
            var artistRes = new ArtistResource(artist);

            View longFormBook = new LongFormView(bookRes);
            View longFormArtist = new LongFormView(artistRes);
            View shortFormBook = new ShortFormView(bookRes);
            View shortFormArtist = new ShortFormView(artistRes);

            Console.WriteLine("First the longforms:");
            Console.WriteLine($"Book: {longFormBook.Show()}");
            Console.WriteLine($"Artist: {longFormArtist.Show()}");
            Console.WriteLine();
            Console.WriteLine("Second the shortforms:");
            Console.WriteLine($"Book: {shortFormBook.Show()}");
            Console.WriteLine($"Artist: {shortFormArtist.Show()}");
        }
    }
}
