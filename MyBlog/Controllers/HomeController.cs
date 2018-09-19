using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //index
        public ActionResult Index()
        {
            return View();
        }

        //Details详情
        public ActionResult Details()
        {
            return View();
        }

        //Eassay 随笔
        public ActionResult Essay()
        {
            return View();
        }



    }
}