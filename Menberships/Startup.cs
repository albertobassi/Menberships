using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Menberships.Startup))]
namespace Menberships
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
