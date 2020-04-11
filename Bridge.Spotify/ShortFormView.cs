using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public class ShortFormView : View
    {
        public ShortFormView(IResource resource) : base(resource)
        {
        }

        public override string Show() => $"This is short and small form with only view with \ntitle: {_resource.Title()}";
    }
}
