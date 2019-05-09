using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaraNademiMovieStore.Startup))]
namespace SaraNademiMovieStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
