using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiLanMVC.Controllers
{
    public class BlController : MyController
    {
        // GET: Bl
        public ActionResult Index()
        {
            return View();
        }
    }
}