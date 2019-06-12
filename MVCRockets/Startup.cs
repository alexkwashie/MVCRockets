using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRockets.Startup))]
namespace MVCRockets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
