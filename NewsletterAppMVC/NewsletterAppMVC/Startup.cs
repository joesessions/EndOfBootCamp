using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsletterAppMVC.Startup))]
namespace NewsletterAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
