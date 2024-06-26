using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLDT_lession09_Entity_Framework___Database_First.Models;

namespace NLDT_lession09_Entity_Framework___Database_First.Controllers
{
    public class NldtKhoasController : Controller
    {
        private NldtK22cnt3Lession07DbEntities db = new NldtK22cnt3Lession07DbEntities();

        // GET: NldtKhoas
        public ActionResult NLDTIndex()
        {
            return View(db.NldtKhoa.ToList());
        }

        // GET: NldtKhoas/Details/5
        public ActionResult NLDTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtKhoa nldtKhoa = db.NldtKhoa.Find(id);
            if (nldtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nldtKhoa);
        }

        // GET: NldtKhoas/Create
        public ActionResult NLDTCreate()
        {
            return View();
        }

        // POST: NldtKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTCreate([Bind(Include = "NldtMaKH,NldttenKH,NldtTrangThai")] NldtKhoa nldtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NldtKhoa.Add(nldtKhoa);
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }

            return View(nldtKhoa);
        }

        // GET: NldtKhoas/Edit/5
        public ActionResult NLDTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtKhoa nldtKhoa = db.NldtKhoa.Find(id);
            if (nldtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nldtKhoa);
        }

        // POST: NldtKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTEdit([Bind(Include = "NldtMaKH,NldttenKH,NldtTrangThai")] NldtKhoa nldtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nldtKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }
            return View(nldtKhoa);
        }

        // GET: NldtKhoas/Delete/5
        public ActionResult NLDTDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtKhoa nldtKhoa = db.NldtKhoa.Find(id);
            if (nldtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nldtKhoa);
        }

        // POST: NldtKhoas/Delete/5
        [HttpPost, ActionName("NLDTDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTDeleteConfirmed(string id)
        {
            NldtKhoa nldtKhoa = db.NldtKhoa.Find(id);
            db.NldtKhoa.Remove(nldtKhoa);
            db.SaveChanges();
            return RedirectToAction("NLDTIndex");
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
