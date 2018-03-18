using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(parcial.Startup))]
namespace parcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
