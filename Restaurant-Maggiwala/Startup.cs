using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurant_Maggiwala.Startup))]
namespace Restaurant_Maggiwala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
