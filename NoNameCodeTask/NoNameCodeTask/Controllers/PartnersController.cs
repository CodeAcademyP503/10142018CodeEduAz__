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
    public class PartnersController : Controller
    {
        private CodeTaskDbContext db = new CodeTaskDbContext();

        // GET: Partners
        public ActionResult Index()
        {
            return View(db.PartnersAcademies.ToList());
        }

        // GET: Partners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnersAcademy partnersAcademy = db.PartnersAcademies.Find(id);
            if (partnersAcademy == null)
            {
                return HttpNotFound();
            }
            return View(partnersAcademy);
        }

        // GET: Partners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LogoPath,ClickPath")] PartnersAcademy partnersAcademy)
        {
            if (ModelState.IsValid)
            {
                db.PartnersAcademies.Add(partnersAcademy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partnersAcademy);
        }

        // GET: Partners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnersAcademy partnersAcademy = db.PartnersAcademies.Find(id);
            if (partnersAcademy == null)
            {
                return HttpNotFound();
            }
            return View(partnersAcademy);
        }

        // POST: Partners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LogoPath,ClickPath")] PartnersAcademy partnersAcademy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partnersAcademy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partnersAcademy);
        }

        // GET: Partners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnersAcademy partnersAcademy = db.PartnersAcademies.Find(id);
            if (partnersAcademy == null)
            {
                return HttpNotFound();
            }
            return View(partnersAcademy);
        }

        // POST: Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartnersAcademy partnersAcademy = db.PartnersAcademies.Find(id);
            db.PartnersAcademies.Remove(partnersAcademy);
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
