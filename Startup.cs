﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(re259315_MIS4200.Startup))]
namespace re259315_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
