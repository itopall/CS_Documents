using _01_WebApi.OAuth.Providers;
using _13_WebApi;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(_01_WebApi.OAuth.Startup))]
namespace _01_WebApi.OAuth
{
    //Servis çalışmaya başlarken Owin pipeline'ını ayağa kaldırabilmek için Startup'u hazırlıyoruz.
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();

            ConfigureOAuth(appBuilder);

            WebApiConfig.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);
        }

        private void ConfigureOAuth(IAppBuilder appBuilder)
        {
            OAuthAuthorizationServerOptions oAuthAuthorizationServerOptions = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new Microsoft.Owin.PathString("/token"), //token'ın alınacağı adres burada belirlenir.
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true,
                Provider = new SimpleAuthorizationServerProvider()
            };

            //Token üretimini gerçekleştirebilmek için authorization ayarı yapılıyor.
            appBuilder.UseOAuthAuthorizationServer(oAuthAuthorizationServerOptions);

            //Authentication Type olarak Bearer Authentication'ı kullanacağımızı belirtiyoruz.
            //Bearer Token, OAuth 2.0 ile gelen standartlaşmış bir token türüdür.
            //Herhangi bir kriptolu veriye ihtiyaç duyulmaksızın client tarafından token isteğinde bulunulur ve server belirli bir zamana sahip access_token üretir.
            //Bearer Token SSL güvenliğine dayanır.
            appBuilder.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}