using RukiKrukiWithUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RukiKrukiWithUsers.Controllers
{
    public class ToolsController : Controller
    {
        // GET: Tools
        public ActionResult Index(int? id)
        {
            List<Tool> tools = new List<Tool>();

            tools.Add(new Tool { Name = "Кусачки", Description = "Кусай, унижай", ID = 1, Image = "", InStock = true, Price = 10 });
            tools.Add(new Tool { Name = "Нож", Description = "Семь раз отмерь, потом подумай и еще раз отмерь", ID = 5, Image = "", InStock = true, Price = 20 });
            tools.Add(new Tool { Name = "Супер Печь", Description = "Я люблю плавить)", ID = 2, Image = "", InStock = true, Price = 30 });
            tools.Add(new Tool { Name = "Круглогубцы", Description = "А папа и не заметил", ID = 3, Image = "", InStock = true, Price = 40 });
            tools.Add(new Tool { Name = "Гравировачная машинка", Description = "И это подарок на 8 марта)", ID = 4, Image = "", InStock = true, Price = 50 });



            Tool temp = null;
            temp = tools.Find(p => p.ID == id);
            if (temp != null)
                return View(temp);
            else
                return View(new Tool { ID = -1, Name = "Not Found!", InStock = false });

        }
    }
}