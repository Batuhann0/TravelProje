using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Sınıflar;

namespace TravelProje.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }


        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}