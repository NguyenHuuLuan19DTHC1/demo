using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult trang_chu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult trang_chu(FormCollection collection)
        {
            var mssv = collection["username"];
            var pass = collection["password"];
            if (mssv.ToString() == "1234" && pass.ToString() == "1234")
            {
                return RedirectToAction("danh_sach", "DSCN");
            }
            return View();
            
        }
    }
}