using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dribbble.AspNetMvc.Startup))]
namespace Dribbble.AspNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
