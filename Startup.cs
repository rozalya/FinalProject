using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetFit.Startup))]
namespace GetFit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
