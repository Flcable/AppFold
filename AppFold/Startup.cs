using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppFold.Startup))]
namespace AppFold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
