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
        List<Tool> tools;

        public HomeController():base()
        {
            tools = new List<Tool>();

            tools.Add(new Tool { Name = "Кусачки", Description = "Кусай, унижай", ID = 1, Image = "", InStock = true, Price = 10 });
            tools.Add(new Tool { Name = "Нож", Description = "Семь раз отмерь, потом подумай и еще раз отмерь", ID = 5, Image = "", InStock = true, Price = 20 });
            tools.Add(new Tool { Name = "Супер Печь", Description = "Я люблю плавить)", ID = 2, Image = "", InStock = true, Price = 30 });
            tools.Add(new Tool { Name = "Круглогубцы", Description = "А папа и не заметил", ID = 3, Image = "", InStock = true, Price = 40 });
            tools.Add(new Tool { Name = "Гравировачная машинка", Description = "И это подарок на 8 марта)", ID = 4, Image = "", InStock = true, Price = 50 });
        }

        public ActionResult Index()
        {
            ProductsContext pt = new ProductsContext();

            Product p = new Product();
            pt.Products.Add(p);

            return View();
        }

        public ActionResult VideoLessons()
        {
            List<Videos> videoLess = new List<Videos>();

            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/L_vQW3xQ" });
            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/w0woKlj5Zd" });

            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/J7ODzbMYf" });
            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/Jf5LQtQ_zY" });
            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/S_Ig8s4xN7c" });


            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/X-w5vJOZHJg" });
            videoLess.Add(new Videos { Name = "fist", UrlVideo = "https://www.youtube.com/embed/vVi2klX_feE" });

            return View(videoLess);
        }

        public ActionResult Materials()
        {
            ProductsContext db = new ProductsContext();

            return View(db.Products);
        }

        public ActionResult Tools()
        {
            return View(tools);
        }

        public ActionResult ToolsMarket()
        {
            return View(tools);
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
    }
}