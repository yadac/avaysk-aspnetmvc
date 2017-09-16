using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(avaysk_aspnetmvc.Startup))]
namespace avaysk_aspnetmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
