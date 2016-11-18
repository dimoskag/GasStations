using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gas_Station.Startup))]
namespace Gas_Station
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
