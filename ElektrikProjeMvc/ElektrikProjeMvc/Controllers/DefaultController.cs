using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElektrikProjeMvc.Models.Entity;


namespace ElektrikProjeMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ElektrikProjeDBEntities1 db = new ElektrikProjeDBEntities1();

        //public ActionResult Index(string p,int sayfa = 1)
        //{
        //    //var getir = db.TBL_ELEKTRIKPROJE.ToList().ToPagedList(sayfa, 10);
        //    //return View(getir);
        //    return View(db.TBL_ELEKTRIKPROJE.Where(x => x.PROJEAD.Contains(p) || p == null).ToPagedList(sayfa, 10));

        //}

        [Authorize]
        public ActionResult Index()
        {
            //var arama = from x in db.TBL_ELEKTRIKPROJE select x;
            //if (!string.IsNullOrEmpty(p))
            //{
            //    arama = arama.Where(x => x.PROJEAD.Contains(p) || p == null);

            //}
            //return View(arama.ToList().ToPagedList(sayfa, 10));
            var degerler = db.TBL_ELEKTRIKPROJE.ToList();
            return View(degerler);

        }
        [Authorize]
        [HttpGet]
        public ActionResult YeniProje()
        {
            List<SelectListItem> degerler = new List<SelectListItem>();
            degerler = (from i in db.iller.ToList()
                        select new SelectListItem
                        {
                            Text = i.sehir,
                            Value = i.id.ToString()

                        }).ToList();
            ViewBag.dgr = degerler;
            IlceGetir(11);
            return View();


        }
        [Authorize]
        public JsonResult IlceGetir(int id)
        {

            int Id = id;

            List<SelectListItem> result = new List<SelectListItem>();


            result = (from i in db.ilceler.Where(x => x.sehir == Id).ToList()
                      select new SelectListItem
                      {
                          Text = i.ilce,
                          Value = i.id.ToString()

                      }).ToList();
            ViewBag.dgr2 = result;
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [Authorize]
        [HttpPost]
        public ActionResult YeniProje(TBL_ELEKTRIKPROJE p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniProje");
            }

            db.TBL_ELEKTRIKPROJE.Add(p1);
            p1.FLAG = "A";
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult ProjeGetir(int id)
        {

            var proje = db.TBL_ELEKTRIKPROJE.Find(id);
            List<SelectListItem> degerler = new List<SelectListItem>();
            degerler = (from i in db.iller.Where(x => x.id == 11).ToList()
                        select new SelectListItem
                        {
                            Text = i.sehir,
                            Value = i.id.ToString()

                        }).ToList();
            ViewBag.dgr = degerler;
            IlceGetir(11);

            return View("ProjeGetir", proje);
        }
        [Authorize]
        public ActionResult Guncelle(TBL_ELEKTRIKPROJE p1)
        {
            if (!ModelState.IsValid)
            {
                return View("ProjeGetir");
            }
            //p1 den göndermiş olduğum projenin id sini bulup.
            var query = db.TBL_ELEKTRIKPROJE.Find(p1.PROJEID);
            query.PROJEAD = p1.PROJEAD.ToUpper();
            query.MEVKI = p1.MEVKI;
            query.ADA = p1.ADA;
            query.PARSEL = p1.PARSEL;
            query.ELEKTRIKPROJENUSHA = p1.ELEKTRIKPROJENUSHA;
            query.ELEKTRIKPROJEDURUM = p1.ELEKTRIKPROJEDURUM;
            query.ELEKTRIKPROJEONYTAR = p1.ELEKTRIKPROJEONYTAR;
            query.TELEKOMPROJENUSHA = p1.TELEKOMPROJENUSHA;
            query.TELEKOMPROJEDURUM = p1.TELEKOMPROJEDURUM;
            query.TELEKOMPROJEONYTAR = p1.TELEKOMPROJEONYTAR;
            query.KONTROLFORMU = p1.KONTROLFORMU;
            query.TEDASDOSYASI = p1.TEDASDOSYASI;
            query.ELEKTRIKCIAD = p1.ELEKTRIKCIAD;
            query.ILETISIM = p1.ILETISIM;
            query.ACIKLAMALAR = p1.ACIKLAMALAR;
            query.ACIKLAMALAR2 = p1.ACIKLAMALAR2;
            query.ACIKLAMALAR3 = p1.ACIKLAMALAR3;
            query.PROJEIL = p1.PROJEIL;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult SIL(int id)
        {
            //var sorgu = db.TBL_ELEKTRIKPROJE.Find(id);
            //sorgu.FLAG = "P";
            //db.SaveChanges();
            //return RedirectToAction("Index");
            var sorgu = db.TBL_ELEKTRIKPROJE.Find(id);
            db.TBL_ELEKTRIKPROJE.Remove(sorgu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}