using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BanMayTinh.Startup))]
namespace BanMayTinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
