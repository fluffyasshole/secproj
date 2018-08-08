using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        dbentityEntities db = new dbentityEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }
    }
}