using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTestApp.Startup))]
namespace MyTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
