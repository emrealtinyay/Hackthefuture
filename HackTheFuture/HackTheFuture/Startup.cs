using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackTheFuture.Startup))]
namespace HackTheFuture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
