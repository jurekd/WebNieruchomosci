using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNieruchomosci.Startup))]
namespace WebNieruchomosci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
