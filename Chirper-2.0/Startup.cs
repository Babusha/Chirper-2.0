using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chirper_2._0.Startup))]
namespace Chirper_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
