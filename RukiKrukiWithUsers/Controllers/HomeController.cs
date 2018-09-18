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



            //videoLess.Add(new Videos { Name = "Second", UrlVideo = "/videos/videoplayback2.mp4" });
            //videoLess.Add(new Videos { Name = "333333", UrlVideo = "/videos/videoplayback3.mp4" });
            //videoLess.Add(new Videos { Name = "4444444", UrlVideo = "/videos/videoplayback4.mp4" });
            //videoLess.Add(new Videos { Name = "fromLocal", UrlVideo= "/videos/videoplayback5.mp4" });
            //videoLess.Add(new Videos { Name = "fromLocal", UrlVideo = "/videos/videoplayback6.mp4" });
            //videoLess.Add(new Videos { Name = "fromLocal", UrlVideo = "/videos/videoplayback7.mp4" });

            return View(videoLess);
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