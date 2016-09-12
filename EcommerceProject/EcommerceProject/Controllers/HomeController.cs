using EcommerceProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EcommerceProject.Controllers
{
    public class HomeController : Controller
    {
        private EcommerceDBEntities db = new EcommerceDBEntities();
        public ActionResult Index()
        {
            //var result = db.Products.Where(i => i.CategoryID == 1)
            var homeItemPhone = from x in db.Products.Where(i => i.CategoryID == 1).Take(10)
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

            var homeItemTablet = from x in db.Products.Where(i => i.CategoryID == 2).Take(10)
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
            var homeItemLaptop = from x in db.Products.Where(i => i.CategoryID == 3).Take(10)
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
            ViewBag.HomeItemPhone = homeItemPhone;
            ViewBag.HomeItemTablet = homeItemTablet;
            ViewBag.HomeItemLaptop = homeItemLaptop;
            return View();
        }

        public ActionResult GetDataHomePage()
        {
            //var products = db.Products.Include(p => p.Category).Include(p => p.Manufacturer);
            var products = from x in db.Products.Where(i => i.CategoryID == 1).Take(10)
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
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}