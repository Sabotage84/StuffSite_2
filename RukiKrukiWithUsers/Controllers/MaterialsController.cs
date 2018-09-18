using RukiKrukiWithUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RukiKrukiWithUsers.Controllers
{
    public class MaterialsController : Controller
    {
        // GET: Materials
        public ActionResult Index(int? id)
        {
            ProductsContext db = new ProductsContext();

            List<Product> products = db.Products.ToList();
            Product temp = null;
            temp = products.Find(p => p.ID == id);
            if (temp != null)
                return View(temp);
            else
                return View(new Product { ID = -1, Name = "Not Found!", IsInStock = false });
        }
    }
}