using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;
using StokProje.Models.Entity;

namespace StokProje.Controllers
{

    public class UrunController : Controller
    {
        // GET: Urun
        StokDBEntities db = new StokDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_URUNLER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler = new List<SelectListItem>();
            degerler = (from i in db.TBL_KATEGORILER.ToList()
                        select new SelectListItem
                        {
                            Text = i.KATEGORIAD,
                            Value = i.KATEGORIID.ToString()
                        }).ToList();


            ViewBag.dgr = degerler;

            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(TBL_URUNLER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniUrun");
            }
          
            var ktg = db.TBL_KATEGORILER.Where(m => m.KATEGORIID == p1.URUNKATEGORİ).FirstOrDefault();

            p1.TBL_KATEGORILER = ktg;
            db.TBL_URUNLER.Add(p1);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var urun = db.TBL_URUNLER.Find(id);
            db.TBL_URUNLER.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = db.TBL_URUNLER.Find(id);

            List<SelectListItem> deger = (from i in db.TBL_KATEGORILER.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KATEGORIAD,
                                              Value = i.KATEGORIID.ToString()
                                          }).ToList();

            ViewBag.dgr = deger;
            return View("UrunGetir", urun);
        }
        public ActionResult Guncelle(TBL_URUNLER p)
        {
            if (!ModelState.IsValid)
            {
                return View("UrunGetir");
            }
            //p1 den göndermiş olduğum kategorinin id sini bulup.
            var urun = db.TBL_URUNLER.Find(p.URUNID);
            urun.URUNAD = p.URUNAD.ToUpper();
            urun.FIYAT = p.FIYAT;
            urun.MARKA = p.MARKA;
            urun.STOK = p.STOK;
            var ktgr = db.TBL_KATEGORILER.Where(m => m.KATEGORIID == p.URUNKATEGORİ).FirstOrDefault();
            urun.URUNKATEGORİ = ktgr.KATEGORIID;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
