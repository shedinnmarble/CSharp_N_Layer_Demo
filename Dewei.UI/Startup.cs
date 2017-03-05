using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dewei.UI.Startup))]
namespace Dewei.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
