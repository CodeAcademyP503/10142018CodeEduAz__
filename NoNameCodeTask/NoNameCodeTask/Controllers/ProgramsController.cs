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
    public class ProgramsController : Controller
    {
        private CodeTaskDbContext db = new CodeTaskDbContext();

        // GET: Programs
        public ActionResult Index()
        {
            return View(db.SubjectPrograms.ToList());
        }

        // GET: Programs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectPrograms subjectPrograms = db.SubjectPrograms.Find(id);
            if (subjectPrograms == null)
            {
                return HttpNotFound();
            }
            return View(subjectPrograms);
        }

        // GET: Programs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Programs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ClickPath,IconPath")] SubjectPrograms subjectPrograms)
        {
            if (ModelState.IsValid)
            {
                db.SubjectPrograms.Add(subjectPrograms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subjectPrograms);
        }

        // GET: Programs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectPrograms subjectPrograms = db.SubjectPrograms.Find(id);
            if (subjectPrograms == null)
            {
                return HttpNotFound();
            }
            return View(subjectPrograms);
        }

        // POST: Programs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ClickPath,IconPath")] SubjectPrograms subjectPrograms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjectPrograms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subjectPrograms);
        }

        // GET: Programs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectPrograms subjectPrograms = db.SubjectPrograms.Find(id);
            if (subjectPrograms == null)
            {
                return HttpNotFound();
            }
            return View(subjectPrograms);
        }

        // POST: Programs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubjectPrograms subjectPrograms = db.SubjectPrograms.Find(id);
            db.SubjectPrograms.Remove(subjectPrograms);
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
