using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace API
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            //config.Filters.Add(new AuthorizeAttribute());
            ConfigureWebApiDocumentation(config);

            appBuilder.UseWebApi(config);
        }

        public static void ConfigureWebApiDocumentation(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.IncludeXmlComments(GetXmlCommentsPath());
                c.SingleApiVersion("v1", "Servup API")
                .Description("Servup API for application layer.")
                .TermsOfService("Servup terms of service")
                .License(lc => lc
                    .Name("Servup API License")
                    .Url("http://tempuri.org/license"))
                .Contact(cc => cc
                    .Name("Imran Shabbir")
                    .Url("http://tempuri.org/contact")
                    .Email("imran.shabbbir@gmail.com"));
            }).EnableSwaggerUi();


            //var defaultSettings = new JsonSerializerSettings
            //{
            //    Formatting = Formatting.Indented,
            //    ContractResolver = new CamelCasePropertyNamesContractResolver(),
            //    Converters = new List<JsonConverter> { new StringEnumConverter { CamelCaseText = true }, }
            //};
            //JsonConvert.DefaultSettings = () => { return defaultSettings; };
            //config.Formatters.Clear();
            //config.Formatters.Add(new JsonMediaTypeFormatter());
            //config.Formatters.JsonFormatter.SerializerSettings = defaultSettings;

            //config.MapHttpAttributeRoutes();
            //config.EnableSwagger(c =>
            //{
            //    c.IncludeXmlComments(GetXmlCommentsPath());
            //    c.SingleApiVersion("1.0", "Owin Swashbuckle Demo");
            //}).EnableSwaggerUi();
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}API.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
