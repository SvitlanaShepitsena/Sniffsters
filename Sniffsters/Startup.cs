using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sniffsters.Startup))]
namespace Sniffsters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
