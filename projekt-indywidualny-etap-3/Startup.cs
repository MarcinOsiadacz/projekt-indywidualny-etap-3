using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekt_indywidualny_etap_3.Startup))]
namespace projekt_indywidualny_etap_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
