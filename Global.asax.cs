using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace DenemeDevExpress
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
			DenemeDevExpress.CorsSupport.HandlePreflightRequest(HttpContext.Current);
		}

	}
}