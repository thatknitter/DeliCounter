using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliCounter.Startup))]
namespace DeliCounter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
