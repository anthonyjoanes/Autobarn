using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoBarn.WebUI.Startup))]
namespace AutoBarn.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
