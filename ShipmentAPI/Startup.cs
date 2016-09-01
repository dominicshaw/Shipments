using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using ShipmentAPI;

[assembly: OwinStartup(typeof(Startup))]
namespace ShipmentAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);

            ConfigureAuthZero(app);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}