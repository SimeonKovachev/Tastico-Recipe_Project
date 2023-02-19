using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tastico.Startup))]
namespace Tastico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
