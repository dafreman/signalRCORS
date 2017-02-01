using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRResearch.Web.Startup))]
namespace SignalRResearch.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
