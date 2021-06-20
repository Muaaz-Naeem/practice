using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.AuthData
{
    public class AuthAttribute : AuthorizeAttribute
    {
        private bool localAllowed;

        public AuthAttribute(bool localAllowed)
        {
             this.localAllowed = localAllowed;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {   
            if (httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }
        }
       
    }   
}