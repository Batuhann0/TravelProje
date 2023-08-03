using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Sınıflar;

namespace TravelProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();

        #region Blog Listele
        [Authorize] //yetkilendirme işlemi login sayfasına yönlendircek
        public ActionResult Admin()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        #endregion

        #region BLOG EKLEME
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }
        #endregion

        #region Blog Sil
        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }
        #endregion

        #region BLOG GÜNCELLEME

        public ActionResult BlogGetir(int id)
        {
            var x = c.Blogs.Find(id);
            return View("BlogGetir", x);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var bgl = c.Blogs.Find(b.ID);
            bgl.Baslik = b.Baslik;
            bgl.Tarih = b.Tarih;
            bgl.BlogImage = b.BlogImage;
            bgl.Aciklama = b.Aciklama;

            c.SaveChanges();

            return RedirectToAction("Admin");
        }
        #endregion


        #region YORUM LİSTELE
        public ActionResult Yorumlar()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        #endregion

        #region YORUM SİL
        public ActionResult YorumSil(int id)
        {
            var x = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(x);
            c.SaveChanges();

            return RedirectToAction("Yorumlar");
        } 
        #endregion

        public ActionResult YorumGetir(int id)
        {
            var x = c.Yorumlars.Find(id);
            return View("YorumGetir", x);
        }

        public ActionResult YorumGüncelle(Yorumlar y)
        {
            var x = c.Yorumlars.Find(y.ID);
            x.Kullanici = y.Kullanici;
            x.Mail = y.Mail;
            x.Yorum = y.Yorum;
            x.Blog = y.Blog;

            c.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
    }
}