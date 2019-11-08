using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoPlayerDenemeVideojs.Models;
namespace VideoPlayerDenemeVideojs.Controllers
{

    public class HomeController : Controller
    {
        AkademinyaEntities db = new AkademinyaEntities();

        public ActionResult Index(int id)
        {
            var UyeVideo = db.UyeVideo.FirstOrDefault(x => x.Id == id);
            return View(UyeVideo);
        }
        
        [HttpPost]
        public ActionResult Index(string deger, Boolean izlendimi, int id)
        {
            UyeVideo uv = db.UyeVideo.FirstOrDefault(x => x.Id == id);
            uv.KalinanZaman = deger;
            uv.Izlendi = izlendimi;
            db.SaveChanges();
            return Json(true,JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}