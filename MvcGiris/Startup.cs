using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcGiris.Startup))]
namespace MvcGiris
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
