using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAuthorizationFilter.Controllers
{
    //驗證使用者
    [Authorize(Users = "Alex,Bonny")]
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Name = "陳小明";
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

    }
}