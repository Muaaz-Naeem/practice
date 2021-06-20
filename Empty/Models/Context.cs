using Empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empty.Models
{
    public class Context
    {
        public void LoadContextItems(ActionExecutedContext filterContext)
        {
            ContextViewModel.contextItems.Clear();
            ContextViewModel.contextItems.Add(new ContextItem { property = "URL", Value = filterContext.HttpContext.Request.Url.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "URL Length", Value = filterContext.HttpContext.Request.RawUrl.Length.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Path", Value = filterContext.HttpContext.Request.Path.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Server", Value = filterContext.HttpContext.Server.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "User IP Address", Value = filterContext.HttpContext.Request.UserHostAddress.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "User Host Name", Value = filterContext.HttpContext.Request.UserHostName.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Browser", Value = filterContext.HttpContext.Request.Browser.Browser.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Languages", Value = getLanguages(filterContext) });
            ContextViewModel.contextItems.Add(new ContextItem { property = "User", Value = filterContext.HttpContext.User.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Authenticated ?", Value = filterContext.HttpContext.Request.IsAuthenticated.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Query String", Value = filterContext.HttpContext.Request.QueryString.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "HTTP Method", Value = filterContext.HttpContext.Request.HttpMethod.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Is Ajax Request ?", Value = filterContext.HttpContext.Request.IsAjaxRequest().ToString() });
            //ContextViewModel.items.Add(new ContextItem { property = "Params", Value = filterContext.HttpContext.Request.Params.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Form Variables", Value = filterContext.HttpContext.Request.Form.ToString() });
            ContextViewModel.contextItems.Add(new ContextItem { property = "Secure Connection ?", Value = filterContext.HttpContext.Request.IsSecureConnection.ToString() });

            //ContextViewModel.items.Add(new ContextItem { property = "Headers", Value = filterContext.HttpContext.Request.Headers.ToString() });


            //var viewBag = filterContext.Controller.ViewBag;
            //viewBag.url = filterContext.HttpContext.Request.Url;
            // viewBag.user = filterContext.HttpContext.User;

        }

        private string getLanguages(ActionExecutedContext filterContext)
        {
            string languages = "";
            foreach (var item in filterContext.HttpContext.Request.UserLanguages)
            {
                languages += item + " ,";
            }
            return languages;
        }

        private string getUrlReferer(ActionExecutedContext filterContext)
        {
            var urlReferer = filterContext.HttpContext.Request.UrlReferrer.ToString();
            if (urlReferer == null)
            {
                return "";
            }
            return urlReferer;
        }
    }
}