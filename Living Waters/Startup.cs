using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Living_Waters.Startup))]
namespace Living_Waters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
