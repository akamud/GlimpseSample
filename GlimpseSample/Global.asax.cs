using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace GlimpseSample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Enable this and Glimpse starts working again

            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
