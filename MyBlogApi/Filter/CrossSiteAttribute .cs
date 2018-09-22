using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace MyBlogApi.Filter
{
    public class CrossSiteAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        private string originHeaderdefault;

        public string AccessControlAllowOrigin { get; private set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {

            AccessControlAllowOrigin = "Access-Control-Allow-Origin";
            originHeaderdefault = "*";//允许访问的url
            actionExecutedContext.Response.Headers.Add(AccessControlAllowOrigin, originHeaderdefault);
        }



    }
}