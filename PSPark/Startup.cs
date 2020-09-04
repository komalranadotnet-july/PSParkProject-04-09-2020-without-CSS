using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSPark.Startup))]
namespace PSPark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
