using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery練習.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectorDemo()
        {
            return View();
        }

        public ActionResult JsonData(string id, string name)
        {
            var data = new { EmpId = id, EmpName = name, Age = 25 };
            return Json( data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult JsonData2(string id, string name)
        {
            //如果是Ajax要求就回傳Json，如果不是就回傳View
            if (Request.IsAjaxRequest())
            {
                var data =
                    new { empId = id, EmpName = name, Age = 25 };
                return Json(
                    data, JsonRequestBehavior.AllowGet);
            }
            return View();
        }
        public ActionResult AjaxDemo()
        {
            return View();
        }
    }
}