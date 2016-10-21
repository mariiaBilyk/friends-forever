using System.Web.Http;
using FriendsForever.API;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace FriendsForever.API {
    public partial class Startup {

        public void Configuration ( IAppBuilder app ) {
            var config = new HttpConfiguration();

            WebApiConfig.Register( config );

            ConfigureAuthZero( app );

            app.UseCors( CorsOptions.AllowAll );
            app.UseWebApi( config );
        }
    }
}