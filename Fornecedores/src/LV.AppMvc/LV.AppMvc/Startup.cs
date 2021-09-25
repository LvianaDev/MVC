using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV.AppMvc.Startup))]
namespace LV.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
