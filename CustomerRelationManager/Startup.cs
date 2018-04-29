using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerRelationManager.Startup))]
namespace CustomerRelationManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
