using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EWP___Code_first.Startup))]
namespace EWP___Code_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
