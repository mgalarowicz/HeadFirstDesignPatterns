using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Spotify
{
    public abstract class View
    {
        protected readonly IResource _resource;

        protected View(IResource resource)
        {
            _resource = resource;
        }

        public abstract string Show();
    }
}
