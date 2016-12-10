using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantJISH_phase21.Startup))]
namespace RestaurantJISH_phase21
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
