using LMS.BLL;
using LMS.Model;
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
            int[] a = new int[19];
            for (int i=0;i<19;i++)
            {
                a[i] = i;
            }
            ViewData["dt"] = a;
            return View("Main");
            //LMS_Admin admin = new LMS_Admin();
            //LMS_AdminBLL _bll = new LMS_AdminBLL();
            //string name = Request.Form["name"];
            //string pwd = Request.Form["pwd"];
            //admin = _bll.Login(name, pwd);
            //if (admin.Adminnumber<1)
            //{
            //    ViewData["loginMsg"] = "error";
            //    return View("index");
            //}else
            //{
            //    ViewData["loginMsg"] = "ok";
            //    ViewData["admin"] = admin;
            //    return View("main");
            //}
        }
    }
}