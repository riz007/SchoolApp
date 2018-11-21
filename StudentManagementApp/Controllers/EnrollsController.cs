using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class EnrollsController : Controller
    {
        private dbstudentEntities db = new dbstudentEntities();

        // GET: Enrolls
        public ActionResult Index()
        {
            return View(db.Enrolls.ToList());
        }

        // GET: Enrolls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll enroll = db.Enrolls.Find(id);
            if (enroll == null)
            {
                return HttpNotFound();
            }
            return View(enroll);
        }

        // GET: Enrolls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrolls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "enrollID,studentID,sectionID,enrollDate")] Enroll enroll)
        {
            if (ModelState.IsValid)
            {
                db.Enrolls.Add(enroll);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enroll);
        }

        // GET: Enrolls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll enroll = db.Enrolls.Find(id);
            if (enroll == null)
            {
                return HttpNotFound();
            }
            return View(enroll);
        }

        // POST: Enrolls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "enrollID,studentID,sectionID,enrollDate")] Enroll enroll)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enroll).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enroll);
        }

        // GET: Enrolls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll enroll = db.Enrolls.Find(id);
            if (enroll == null)
            {
                return HttpNotFound();
            }
            return View(enroll);
        }

        // POST: Enrolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enroll enroll = db.Enrolls.Find(id);
            db.Enrolls.Remove(enroll);
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
