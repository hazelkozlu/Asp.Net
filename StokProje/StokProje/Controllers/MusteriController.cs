using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokProje.Models.Entity;

namespace StokProje.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        StokDBEntities db = new StokDBEntities();
        public ActionResult Index(string p)
        {
            //var query = db.TBL_MUSTERILER.ToList();
            //return View(query);

            var degerler = from d in db.TBL_MUSTERILER
                           select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.MUSTERIAD.Contains(p));
            }
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBL_MUSTERILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }
            db.TBL_MUSTERILER.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SIL(int id)
        {
            var query = db.TBL_MUSTERILER.Find(id);
            db.TBL_MUSTERILER.Remove(query);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.TBL_MUSTERILER.Find(id);
            return View("MusteriGetir", mus);
        }
        public ActionResult Guncelle(TBL_MUSTERILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("MusteriGetir");
            }
            //p1 den göndermiş olduğum müşterinin id sini bulup.
            var query = db.TBL_MUSTERILER.Find(p1.MUSTERIID);
            query.MUSTERIAD = p1.MUSTERIAD.ToUpper();
            query.MUSTERISOYAD = p1.MUSTERISOYAD.ToUpper();
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}