using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(automated_teller_machine.Startup))]
namespace automated_teller_machine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
