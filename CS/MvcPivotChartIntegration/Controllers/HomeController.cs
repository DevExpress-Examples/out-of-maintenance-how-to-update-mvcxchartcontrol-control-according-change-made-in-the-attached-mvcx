using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [ValidateInput(false)]
        public ActionResult PivotGridPartial()
        {
            return PartialView("_PivotGridPartial", GetData());
        }

        public ActionResult ChartPartial()
        {
            return PartialView("_ChartPartial", GetData());
        }
        public static DataTable GetData()
        {
            string[] names = new string[] { "Aaa", "Bbb", "Ccc", "Ddd" };
            
            DataTable dt = new DataTable();
            Random _r = new Random();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(decimal));
            for (int i = 0; i < 28; i++)
                dt.Rows.Add(DateTime.Today.AddHours(6 * i), names[i % 4], i % 5 * 6 + i % 3 * 7 + 20);
            return dt;
        }
    }
}
