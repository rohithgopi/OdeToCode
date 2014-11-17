using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeToFood.Startup))]
namespace OdeToFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
