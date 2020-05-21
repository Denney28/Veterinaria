using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vterinaria.Web.Startup))]
namespace Vterinaria.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
