using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSandBoxMVC.Startup))]
namespace WebSandBoxMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
