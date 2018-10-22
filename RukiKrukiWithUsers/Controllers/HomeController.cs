using RukiKrukiWithUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RukiKrukiWithUsers.Controllers
{
    public class HomeController : Controller
    {
       
        ToolsContext toolsDB = new ToolsContext();

        public HomeController():base()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VideoLessons()
        {
            VideosContext videoLess = new VideosContext();
            return View(videoLess.AllVideos.ToList());
        }

        public ActionResult Materials()
        {
            ProductsContext db = new ProductsContext();

            return View(db.Products);
        }

        public ActionResult Tools()
        {
            return View(toolsDB.Tools);
        }

        public ActionResult ToolsMarket()
        {
            return View(toolsDB.Tools);
        }

        [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "moderator")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Faq()
        {
            ViewBag.Message = "Forum";

            return View();
        }
    }
}