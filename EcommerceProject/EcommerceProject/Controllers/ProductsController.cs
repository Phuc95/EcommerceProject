using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EcommerceProject.Models;

namespace EcommerceProject.Controllers
{
    public class ProductsController : Controller
    {
        private EcommerceDBEntities db = new EcommerceDBEntities();
        //int currentProductType;

        // GET: Products
        public ActionResult Index(int productType)
        {
            ViewBag.currentProductType = productType;
            var products = from x in db.Products.Where(i => i.CategoryID == productType)
                           select new HomeItem
                           {
                               ProductName = x.ProductName,
                               ProductPrice = x.SellingPrice.ToString(),
                               ProductImage = x.ProductImages.FirstOrDefault().ImagePath,
                               CPU = x.ProductDetails.FirstOrDefault().CPU,
                               OS = x.ProductDetails.FirstOrDefault().OS,
                               RAM = x.ProductDetails.FirstOrDefault().RAM,
                               Screen = x.ProductDetails.FirstOrDefault().Screen,
                               InternalStorage = x.ProductDetails.FirstOrDefault().InternalStorage
                           };
            ViewBag.Manurfacturer = db.GetManufactureList(productType).ToList();
            ViewBag.productTypeName = db.Categories.Where(i => i.CategoryID == productType).SingleOrDefault().CategoryName;
            return View(products.ToList());
        }

        public ActionResult FilterProduct(int productManufacturer, int productType) {
            ViewBag.currentProductType = productType;
            ViewBag.selectedManufacturer = productManufacturer;
            var result = from x in db.Products.Where(i => i.ManufacturerID == productManufacturer && i.CategoryID == productType)
                         select new HomeItem
                         {
                             ProductName = x.ProductName,
                             ProductPrice = x.SellingPrice.ToString(),
                             ProductImage = x.ProductImages.FirstOrDefault().ImagePath,
                             CPU = x.ProductDetails.FirstOrDefault().CPU,
                             OS = x.ProductDetails.FirstOrDefault().OS,
                             RAM = x.ProductDetails.FirstOrDefault().RAM,
                             Screen = x.ProductDetails.FirstOrDefault().Screen,
                             InternalStorage = x.ProductDetails.FirstOrDefault().InternalStorage
                         };
            ViewBag.Manurfacturer = db.GetManufactureList(productType).ToList();
            ViewBag.productTypeName = db.Categories.Where(i => i.CategoryID == productType).SingleOrDefault().CategoryName;
            return View("~/Views/Products/Index.cshtml", result.ToList());
        }

        public ActionResult FilterPrice(int minPrice, int? maxPrice, int productType, int? productManufacturer) {
            ViewBag.currentProductType = productType;
            ViewBag.selectedManufacturer = productManufacturer;
            var result = from x in db.Products.Where(i => (i.SellingPrice >= minPrice && (maxPrice.Equals(null) || i.SellingPrice <= maxPrice)) && i.CategoryID == productType &&  (productManufacturer.Equals(null) || i.ManufacturerID == productManufacturer))
                         select new HomeItem
                         {
                             ProductName = x.ProductName,
                             ProductPrice = x.SellingPrice.ToString(),
                             ProductImage = x.ProductImages.FirstOrDefault().ImagePath,
                             CPU = x.ProductDetails.FirstOrDefault().CPU,
                             OS = x.ProductDetails.FirstOrDefault().OS,
                             RAM = x.ProductDetails.FirstOrDefault().RAM,
                             Screen = x.ProductDetails.FirstOrDefault().Screen,
                             InternalStorage = x.ProductDetails.FirstOrDefault().InternalStorage
                         };
            ViewBag.Manurfacturer = db.GetManufactureList(productType).ToList();
            ViewBag.productTypeName = db.Categories.Where(i => i.CategoryID == productType).SingleOrDefault().CategoryName;
            return View("~/Views/Products/Index.cshtml", result.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,CategoryID,ManufacturerID,ProductName,BasisPrice,SellingPrice,CreatedAt")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", product.ManufacturerID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", product.ManufacturerID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,CategoryID,ManufacturerID,ProductName,BasisPrice,SellingPrice,CreatedAt")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", product.ManufacturerID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
