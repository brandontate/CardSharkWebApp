using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardSharkWebApp2.Startup))]
namespace CardSharkWebApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
