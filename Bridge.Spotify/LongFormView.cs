using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public class LongFormView : View
    {
        public LongFormView(IResource resource) : base(resource)
        {
        }

        public override string Show() => $"This is looooong and biiig form view with \nsnippet: {_resource.Snippet()}, " +
                                         $"\ntitle: {_resource.Title()} \nand url: {_resource.Url()}";

    }
}
