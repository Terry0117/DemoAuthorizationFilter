using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoAuthorizationFilter.Controllers
{
    //驗證使用者(可指定特定使用者)
    [Authorize(Users = "Alex,Bonny")]
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Name = User.Identity.Name;
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string id, string password)
        {
            var idArray = new string[] { "Alex", "Bonny", "Cody" };
            var pwdArray = new string[] { "111", "222", "333" };

            //檢查輸入帳密是否存在於上方陣列中
            for (int i = 0; i < idArray.Length; i++) 
            { 
                if (id == idArray[i] && password == pwdArray[i])
                {
                    //表單驗證服務，授權指定帳號
                    FormsAuthentication.RedirectFromLoginPage(id, true);
                    return RedirectToAction("Index"); 
                }
            }
            ViewBag.Error = "帳密驗證失敗";
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); //登出
            return RedirectToAction("Login");
        }

    }
}