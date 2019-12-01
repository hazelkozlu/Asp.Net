using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokProje.Models.Entity;
namespace StokProje.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        StokDBEntities db = new StokDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBL_SATISLAR p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniSatis");
            }
            db.TBL_SATISLAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}