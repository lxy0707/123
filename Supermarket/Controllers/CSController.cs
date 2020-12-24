using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Supermarket.Controllers
{
    public class CSController : Controller
    {
        // GET: CS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }

        //记录查询(菜品销售记录表)
        public ActionResult SelectRecord()
        {
            return Json(SupermarketInfoManager.SelectRecord(),JsonRequestBehavior.AllowGet);
        }

        //统计查询（）
        public ActionResult SelectCount()
        {
            return Json(SupermarketInfoManager.SelectCount(), JsonRequestBehavior.AllowGet);
        }
    }
}