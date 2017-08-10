using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcNorth.Startup))]
namespace MvcNorth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
