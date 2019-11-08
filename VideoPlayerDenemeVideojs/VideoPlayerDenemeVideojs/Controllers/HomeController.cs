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

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string deger, Boolean izlendimi)
        {
            UyeVideo uv = db.UyeVideo.FirstOrDefault(x => x.Id == 1);
            uv.KalinanZaman = deger;
            uv.Izlendi = izlendimi;
            db.SaveChanges();
            return View();
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