using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RukiKrukiWithUsers.Models;

namespace RukiKrukiWithUsers.Controllers
{
    public class VideosController : Controller
    {
        private VideosContext db = new VideosContext();

        // GET: Videos
        public ActionResult Index()
        {
            return View(db.AllVideos.ToList());
        }

        // GET: Videos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Videos videos = db.AllVideos.Find(id);
            if (videos == null)
            {
                return HttpNotFound();
            }
            return View(videos);
        }

        // GET: Videos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Videos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,UrlVideo")] Videos videos)
        {
            if (ModelState.IsValid)
            {
                db.AllVideos.Add(videos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videos);
        }

        // GET: Videos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Videos videos = db.AllVideos.Find(id);
            if (videos == null)
            {
                return HttpNotFound();
            }
            return View(videos);
        }

        // POST: Videos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,UrlVideo")] Videos videos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videos);
        }

        // GET: Videos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Videos videos = db.AllVideos.Find(id);
            if (videos == null)
            {
                return HttpNotFound();
            }
            return View(videos);
        }

        // POST: Videos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Videos videos = db.AllVideos.Find(id);
            db.AllVideos.Remove(videos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
