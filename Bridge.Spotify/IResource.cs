using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string Url();
    }
}
