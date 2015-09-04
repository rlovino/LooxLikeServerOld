using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace LooxLikeAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           // GlobalConfiguration.Configure(WebApiConfig.Register);

			AreaRegistration.RegisterAllAreas();
			// This is where it "should" be
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			// The WebApi routes cannot be initialized here.
			BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
