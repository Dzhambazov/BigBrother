using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineSchool.Web.Startup))]
namespace OnlineSchool.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
