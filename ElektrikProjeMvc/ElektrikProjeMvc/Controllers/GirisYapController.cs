using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElektrikProjeMvc.Models.Entity;
using System.Web.Security;
namespace ElektrikProjeMvc.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        ElektrikProjeDBEntities1 db = new ElektrikProjeDBEntities1();
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(TBL_ADMIN t)
        {
            var bilgiler = db.TBL_ADMIN.FirstOrDefault(x => x.KULLANICI == t.KULLANICI && x.SIFRE == t.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KULLANICI, false);
                return RedirectToAction("Index","Default");
            }
            else
            {
                return View();
            }
        }
            
    }
}