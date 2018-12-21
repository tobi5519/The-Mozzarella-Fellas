using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Mozzarella_Fellas.Startup))]
namespace The_Mozzarella_Fellas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
