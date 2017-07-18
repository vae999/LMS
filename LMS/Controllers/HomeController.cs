using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("index");
        }
        public ActionResult Login()
        {
            string name = Request.Form["name"];
            string pwd = Request.Form["pwd"];
            if (name=="hello"&&pwd=="test")
            {
                return View("main");
            }
            else
            {
                throw new Exception("登录失败");
            }
           
        }
    }
}