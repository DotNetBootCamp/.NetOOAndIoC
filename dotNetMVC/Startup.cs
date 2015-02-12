using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotNetMVC.Startup))]
namespace dotNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
