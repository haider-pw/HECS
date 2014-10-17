using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerce.Web.Startup))]
namespace eCommerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
