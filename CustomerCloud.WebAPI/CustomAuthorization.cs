using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CustomerCloud.WebAPI
{
    public class CustomAuthorization : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization != null)
            {
                var authHeader = actionContext.Request.Headers.Authorization.ToString();
                
                return (authHeader == "A");
                
            }
            else
            {
                return false;
            }

            
        }
    }
}