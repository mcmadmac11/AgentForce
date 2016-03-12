using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inForce.Startup))]
namespace inForce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
