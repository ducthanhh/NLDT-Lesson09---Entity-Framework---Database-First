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
    public class NldtSinhViensController : Controller
    {
        private NldtK22cnt3Lession07DbEntities db = new NldtK22cnt3Lession07DbEntities();

        // GET: NldtSinhViens
        public ActionResult NLDTIndex()
        {
            return View(db.NldtSinhVien.ToList());
        }

        // GET: NldtSinhViens/Details/5
        public ActionResult NLDTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtSinhVien nldtSinhVien = db.NldtSinhVien.Find(id);
            if (nldtSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nldtSinhVien);
        }

        // GET: NldtSinhViens/Create
        public ActionResult NLDTCreate()
        {
            return View();
        }

        // POST: NldtSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTCreate([Bind(Include = "NldtMaSV,NldtTen,NldtHo,NldtPhai,NldtNgaysinh,NldtNoiSinh,NldtMaKH,NldtHocBong,NldtDiemTrungBinh")] NldtSinhVien nldtSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.NldtSinhVien.Add(nldtSinhVien);
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }

            return View(nldtSinhVien);
        }

        // GET: NldtSinhViens/Edit/5
        public ActionResult NLDTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtSinhVien nldtSinhVien = db.NldtSinhVien.Find(id);
            if (nldtSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nldtSinhVien);
        }

        // POST: NldtSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTEdit([Bind(Include = "NldtMaSV,NldtTen,NldtHo,NldtPhai,NldtNgaysinh,NldtNoiSinh,NldtMaKH,NldtHocBong,NldtDiemTrungBinh")] NldtSinhVien nldtSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nldtSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }
            return View(nldtSinhVien);
        }

        // GET: NldtSinhViens/Delete/5
        public ActionResult NLDTDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtSinhVien nldtSinhVien = db.NldtSinhVien.Find(id);
            if (nldtSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nldtSinhVien);
        }

        // POST: NldtSinhViens/Delete/5
        [HttpPost, ActionName("NLDTDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTDeleteConfirmed(string id)
        {
            NldtSinhVien nldtSinhVien = db.NldtSinhVien.Find(id);
            db.NldtSinhVien.Remove(nldtSinhVien);
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
