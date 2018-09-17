using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RukiKrukiWithUsers.Startup))]
namespace RukiKrukiWithUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
