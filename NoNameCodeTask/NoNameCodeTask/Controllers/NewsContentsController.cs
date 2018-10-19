using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NoNameCodeTask.Models;

namespace NoNameCodeTask.Controllers
{
    public class NewsContentsController : Controller
    {
        private CodeTaskDbContext db = new CodeTaskDbContext();

        // GET: NewsContents
        public ActionResult Index()
        {
            return View(db.NewsContents.ToList());
        }

        // GET: NewsContents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsContent newsContent = db.NewsContents.Find(id);
            if (newsContent == null)
            {
                return HttpNotFound();
            }
            return View(newsContent);
        }

        // GET: NewsContents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,TextDate")] NewsContent newsContent)
        {
            if (ModelState.IsValid)
            {
                db.NewsContents.Add(newsContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsContent);
        }

        // GET: NewsContents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsContent newsContent = db.NewsContents.Find(id);
            if (newsContent == null)
            {
                return HttpNotFound();
            }
            return View(newsContent);
        }

        // POST: NewsContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,TextDate")] NewsContent newsContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsContent);
        }

        // GET: NewsContents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsContent newsContent = db.NewsContents.Find(id);
            if (newsContent == null)
            {
                return HttpNotFound();
            }
            return View(newsContent);
        }

        // POST: NewsContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsContent newsContent = db.NewsContents.Find(id);
            db.NewsContents.Remove(newsContent);
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
