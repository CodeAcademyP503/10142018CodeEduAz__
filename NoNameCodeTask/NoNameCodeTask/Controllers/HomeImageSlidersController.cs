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
    public class HomeImageSlidersController : Controller
    {
        private CodeTaskDbContext db = new CodeTaskDbContext();

        // GET: HomeImageSliders
        public ActionResult Index()
        {
            return View(db.HomeImageSliders.ToList());
        }

        // GET: HomeImageSliders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImageSlider homeImageSlider = db.HomeImageSliders.Find(id);
            if (homeImageSlider == null)
            {
                return HttpNotFound();
            }
            return View(homeImageSlider);
        }

        // GET: HomeImageSliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeImageSliders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Path")] HomeImageSlider homeImageSlider)
        {
            if (ModelState.IsValid)
            {
                db.HomeImageSliders.Add(homeImageSlider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeImageSlider);
        }

        // GET: HomeImageSliders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImageSlider homeImageSlider = db.HomeImageSliders.Find(id);
            if (homeImageSlider == null)
            {
                return HttpNotFound();
            }
            return View(homeImageSlider);
        }

        // POST: HomeImageSliders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Path")] HomeImageSlider homeImageSlider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeImageSlider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeImageSlider);
        }

        // GET: HomeImageSliders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImageSlider homeImageSlider = db.HomeImageSliders.Find(id);
            if (homeImageSlider == null)
            {
                return HttpNotFound();
            }
            return View(homeImageSlider);
        }

        // POST: HomeImageSliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeImageSlider homeImageSlider = db.HomeImageSliders.Find(id);
            db.HomeImageSliders.Remove(homeImageSlider);
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
