using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokProje.Models.Entity;

namespace StokProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        StokDBEntities db = new StokDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_KATEGORILER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(TBL_KATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBL_KATEGORILER.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult SIL(int id)
        {
            var query = db.TBL_KATEGORILER.Find(id);
            db.TBL_KATEGORILER.Remove(query);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TBL_KATEGORILER.Find(id);
            return View("KategoriGetir", ktgr);
        }
        public ActionResult Guncelle(TBL_KATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriGetir");
            }
            //p1 den göndermiş olduğum kategorinin id sini bulup.
            var query = db.TBL_KATEGORILER.Find(p1.KATEGORIID);
            query.KATEGORIAD = p1.KATEGORIAD.ToUpper();
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}