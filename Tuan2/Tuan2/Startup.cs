using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan2.Startup))]
namespace Tuan2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
