using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson2p1.Startup))]
namespace lesson2p1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
