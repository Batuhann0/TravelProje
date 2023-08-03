using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Sınıflar;

namespace TravelProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context();
        public ActionResult About()
        {
            //LİSTELEME
            var deger = c.Hakkımızdas.ToList();
            return View(deger);
        }
    }
}