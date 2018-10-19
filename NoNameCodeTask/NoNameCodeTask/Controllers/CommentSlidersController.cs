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
    public class CommentSlidersController : Controller
    {
        private CodeTaskDbContext db = new CodeTaskDbContext();

        // GET: CommentSliders
        public ActionResult Index()
        {
            return View(db.CommentSliders.ToList());
        }

        // GET: CommentSliders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentSlider commentSlider = db.CommentSliders.Find(id);
            if (commentSlider == null)
            {
                return HttpNotFound();
            }
            return View(commentSlider);
        }

        // GET: CommentSliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentSliders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,JobPosition,Text,ImagePath")] CommentSlider commentSlider)
        {
            if (ModelState.IsValid)
            {
                db.CommentSliders.Add(commentSlider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(commentSlider);
        }

        // GET: CommentSliders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentSlider commentSlider = db.CommentSliders.Find(id);
            if (commentSlider == null)
            {
                return HttpNotFound();
            }
            return View(commentSlider);
        }

        // POST: CommentSliders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,JobPosition,Text,ImagePath")] CommentSlider commentSlider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commentSlider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(commentSlider);
        }

        // GET: CommentSliders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentSlider commentSlider = db.CommentSliders.Find(id);
            if (commentSlider == null)
            {
                return HttpNotFound();
            }
            return View(commentSlider);
        }

        // POST: CommentSliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommentSlider commentSlider = db.CommentSliders.Find(id);
            db.CommentSliders.Remove(commentSlider);
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
