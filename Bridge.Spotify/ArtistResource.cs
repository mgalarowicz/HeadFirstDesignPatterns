using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public class ArtistResource : IResource
    {
        private readonly Artist _artist;

        public ArtistResource(Artist artist)
        {
            _artist = artist;
        }

        public string Snippet() => _artist.About;


        public string Title() => _artist.Name;


        public string Url() => _artist.WebPage;

    }
}
