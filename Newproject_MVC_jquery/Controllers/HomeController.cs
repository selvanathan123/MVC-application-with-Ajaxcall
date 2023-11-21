using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Newproject_MVC_jquery.Models;

namespace Newproject_MVC_jquery.Controllers
{
    public class HomeController : Controller
    {
        Database_accessLayer.db dblayer = new Database_accessLayer.db();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult List()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult Getrecord(string prefix)
        {
            DataSet ds = new DataSet();
            List<search> searchlist = new List<search>();
            foreach(DataRow dr in ds.Tables[0].Rows) {
                searchlist.Add(new search
                {
                    Name = dr["Name"].ToString(),
                });
            }
            return Json(searchlist,  JsonRequestBehavior.AllowGet);
        }
    }
}