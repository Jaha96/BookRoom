using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookRoom.Startup))]
namespace BookRoom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
