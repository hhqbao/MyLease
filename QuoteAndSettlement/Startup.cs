using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuoteAndSettlement.Startup))]
namespace QuoteAndSettlement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
