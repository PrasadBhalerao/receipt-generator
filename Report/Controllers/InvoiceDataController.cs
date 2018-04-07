using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Report.Models;
using System.Drawing.Printing; 

namespace Report.Controllers
{
    public class InvoiceDataController : Controller
    {
        private ReportDBContext db = new ReportDBContext();

        // GET: InvoiceData
        public ActionResult Index()
        {
            return View(db.ReceiptData.ToList());
        }

        // GET: InvoiceData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReceiptData invoiceData = db.ReceiptData.Find(id);
            if (invoiceData == null)
            {
                return HttpNotFound();
            }
            return View(invoiceData);
        }

        // GET: InvoiceData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DonationType,Village,City,State,Pincode,MobileNo,AMount")] ReceiptData invoiceData)
        {
            if (ModelState.IsValid)
            {
                db.ReceiptData.Add(invoiceData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //else
            //{
            //    invoiceData.DonationType = db.DonationTypes.ToList();
            //}
            return View(invoiceData);
        }

        // GET: InvoiceData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReceiptData invoiceData = db.ReceiptData.Find(id);
            if (invoiceData == null)
            {
                return HttpNotFound();
            }
            return View(invoiceData);
        }

        // POST: InvoiceData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DonationType,Village,City,State,Pincode,MobileNo,AMount")] ReceiptData invoiceData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invoiceData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invoiceData);
        }

        // GET: InvoiceData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReceiptData invoiceData = db.ReceiptData.Find(id);
            if (invoiceData == null)
            {
                return HttpNotFound();
            }
            return View(invoiceData);
        }

        // POST: InvoiceData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReceiptData invoiceData = db.ReceiptData.Find(id);
            db.ReceiptData.Remove(invoiceData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Print(int id)
        {
            ReceiptData invoiceData = db.ReceiptData.Find(id);
            return View(invoiceData);
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
