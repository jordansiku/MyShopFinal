using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopFinal.WebUI.Startup))]
namespace MyShopFinal.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
