using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empty.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
       // GET: Error
        public ActionResult badrequest()
        {
            return View();
        } 
        public ActionResult notfound()
        {
            return View();
        } public ActionResult internalerror()
        {
            return View();
        }
    }
}