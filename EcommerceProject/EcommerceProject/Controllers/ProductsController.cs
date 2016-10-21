using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EcommerceProject.Models;
using Newtonsoft.Json;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using EcommerceProject.ViewModel;
using PayPal.Api;

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
                               ProductID = x.ProductID,
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
                             ProductID = x.ProductID,
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
            var result = from x in db.Products.Where(i => (i.SellingPrice >= minPrice && (maxPrice.Equals(null) || i.SellingPrice <= maxPrice)) && i.CategoryID == productType && (productManufacturer.Equals(null) || i.ManufacturerID == productManufacturer))
                         select new HomeItem
                         {
                             ProductID = x.ProductID,
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

        public ActionResult Search(string search) {
            var products = from x in db.Products.Where(i => i.ProductName.Contains(search))
                           select new HomeItem
                           {
                               ProductID = x.ProductID,
                               ProductName = x.ProductName,
                               ProductPrice = x.SellingPrice.ToString(),
                               ProductImage = x.ProductImages.FirstOrDefault().ImagePath,
                               CPU = x.ProductDetails.FirstOrDefault().CPU,
                               OS = x.ProductDetails.FirstOrDefault().OS,
                               RAM = x.ProductDetails.FirstOrDefault().RAM,
                               Screen = x.ProductDetails.FirstOrDefault().Screen,
                               InternalStorage = x.ProductDetails.FirstOrDefault().InternalStorage
                           };
            return View(products.ToList());
        }

        public ActionResult ViewDetail(int productID) {
            var products = from x in db.Products.Where(i => i.ProductID == productID)
                           select new ProductDetailView
                           {
                               productID = x.ProductID,
                               productName = x.ProductName,
                               productManufacturer = x.Manufacturer.ManufacturerName,
                               productImages = x.ProductImages.Select(i => i.ImagePath).ToList(),
                               productColor = x.ProductColors.Select(i => i.ColorName).ToList(),
                               productPrice = x.SellingPrice.Value,
                               Screen = x.ProductDetails.FirstOrDefault().Screen,
                               OS = x.ProductDetails.FirstOrDefault().OS,
                               FrontCamera = x.ProductDetails.FirstOrDefault().FrontCamera.Value,
                               RearCamera = x.ProductDetails.FirstOrDefault().RearCamera.Value,
                               CPU = x.ProductDetails.FirstOrDefault().CPU,
                               RAM = x.ProductDetails.FirstOrDefault().RAM,
                               MemoryCard = x.ProductDetails.FirstOrDefault().MemoryCard,
                               SIMCard = x.ProductDetails.FirstOrDefault().SIMCard,
                               Connection = x.ProductDetails.FirstOrDefault().Connection,
                               Battery = x.ProductDetails.FirstOrDefault().Battery,
                               InternalStorage = x.ProductDetails.FirstOrDefault().InternalStorage,
                               Weight = x.ProductDetails.FirstOrDefault().Weight.Value,
                           };
            ViewBag.commentList = (from x in db.Comments.Where(i => i.ProductID == productID).OrderByDescending(i => i.CreatedDate).Take(5)
                                   select new
                                   {
                                       userName = x.User.UserName,
                                       commentDate = x.CreatedDate,
                                       commentContent = x.Comment1
                                   }).ToList().Select(i => new CommentModel {
                                       userName = i.userName,
                                       commentDate = i.commentDate.Value.ToString("dd/MM/yyyy"),
                                       commentContent = i.commentContent
                                   }).ToList();
            ProductDetailView productDetail = products.SingleOrDefault();
            return View(productDetail);
        }

        public string GetColorStatus(string jsonString) {
            JsonColorModel model = JsonConvert.DeserializeObject<JsonColorModel>(jsonString);
            int result = db.ProductColors.Where(i => i.ProductID == model.productID && i.ColorName == model.selectedColor).Select(i => i.QuantityInStock).SingleOrDefault().Value;
            if (result > 0)
            {
                return "Available";
            } else {
                return "Out of stock";
            }
        }

        public string ViewMoreComment(string jsonString)
        {
            CommentModel model = JsonConvert.DeserializeObject<CommentModel>(jsonString);
            var total = db.Comments.Where(i => i.ProductID == model.productID).Count();
            var pageSize = 5;
            var skip = pageSize * (model.page - 1);
            var canpage = skip >= total;
            if (canpage)
            {
                return "false";
            };
            var commentList = (from x in db.Comments.Where(i => i.ProductID == model.productID).OrderByDescending(i => i.CreatedDate).Skip(skip).Take(pageSize)
                               select new
                               {
                                   userName = x.User.UserName,
                                   commentDate = x.CreatedDate,
                                   commentContent = x.Comment1
                               }).ToList().Select(i => new CommentModel
                               {
                                   userName = i.userName,
                                   commentDate = i.commentDate.Value.ToString("dd/MM/yyyy"),
                                   commentContent = i.commentContent
                               }).ToList();
            string json = JsonConvert.SerializeObject(commentList);
            return json;
        }

        public ActionResult ViewCart() {
            return View("~/Views/Products/AddToCart.cshtml");
        }

        public ActionResult AddToCart(int productID, string productColor) {
            var product = db.Products.Where(i => i.ProductID == productID).FirstOrDefault();
            CartItemModel cart = new CartItemModel();
            cart.productID = productID;
            cart.productName = product.ProductName;
            cart.productPrice = product.SellingPrice.Value;
            cart.productImage = product.ProductImages.Select(i => i.ImagePath).FirstOrDefault().ToString();
            cart.productColor = productColor;
            cart.productQuantity = 1;
            List<CartItemModel> cartList;
            if (Session["cart"] == null)
            {
                cartList = new List<CartItemModel>();
                cartList.Add(cart);
                Session["cart"] = cartList;
            }
            else {
                cartList = (List<CartItemModel>)Session["cart"];
                int index = CheckExist(productID, productColor);
                if (index == -1) {
                    cartList.Add(cart);
                } else
                {
                    cartList[index].productQuantity++;
                }
                Session["cart"] = cartList;
            }
            int total = 0;
            foreach (var item in cartList) {
                total = total + (item.productQuantity * item.productPrice);
            }
            ViewBag.total = total;
            return View();
        }

        public int CheckExist(int productID, string productColor) {
            List<CartItemModel> cartList = cartList = (List<CartItemModel>)Session["cart"];
            for (int i = 0; i < cartList.Count(); i++) {
                if (cartList[i].productID == productID && cartList[i].productColor == productColor) {
                    return i;
                }
            }
            return -1;
        }

        public ActionResult DeleteCartItem(int productID, string productColor) {
            List<CartItemModel> cartList = (List<CartItemModel>)Session["cart"];
            int index = CheckExist(productID, productColor);
            cartList.RemoveAt(index);
            Session["cart"] = cartList;
            int total = 0;
            foreach (var item in cartList)
            {
                total = total + (item.productQuantity * item.productPrice);
            }
            ViewBag.total = total;
            return View("~/Views/Products/AddToCart.cshtml");
        }

        private Payment payment;

        public ActionResult Checkout(OrderViewModel orderModel, string paymentMethod)
        {
            if (orderModel == null || paymentMethod == null)
            {
                orderModel = (OrderViewModel)Session["OrderViewModel"];
                paymentMethod = (string)Session["Paymentmethod"];
            }
            else
            {
                Session["OrderViewModel"] = orderModel;
                Session["Paymentmethod"] = paymentMethod;
            }
            if (paymentMethod == "Paypal")
            {
                APIContext apiContext = PaypalConfiguration.GetAPIContext();
                try
                {
                    string payerId = Request.Params["PayerID"];

                    if (string.IsNullOrEmpty(payerId))
                    {
                        //this section will be executed first because PayerID doesn't exist
                        //it is returned by the create function call of the payment class

                        // Creating a payment
                        // baseURL is the url on which paypal sendsback the data.
                        // So we have provided URL of this controller only
                        string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority +
                                    "/Products/Checkout?";

                        //guid we are generating for storing the paymentID received in session
                        //after calling the create function and it is used in the payment execution

                        var guid = Convert.ToString((new Random()).Next(100000));

                        //CreatePayment function gives us the payment approval url
                        //on which payer is redirected for paypal account payment

                        var createdPayment = CreatePayment(apiContext, baseURI + "guid=" + guid, (List<CartItemModel>)Session["cart"]);

                        //get links returned from paypal in response to Create function call

                        var links = createdPayment.links.GetEnumerator();

                        string paypalRedirectUrl = null;

                        while (links.MoveNext())
                        {
                            Links lnk = links.Current;

                            if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                            {
                                //saving the payapalredirect URL to which user will be redirected for payment
                                paypalRedirectUrl = lnk.href;
                            }
                        }

                        // saving the paymentID in the key guid
                        Session.Add(guid, createdPayment.id);

                        return Redirect(paypalRedirectUrl);
                    }
                    else
                    {
                        // This section is executed when we have received all the payments parameters
                        // from the previous call to the function Create
                        // Executing a payment

                        var guid = Request.Params["guid"];

                        var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);

                        if (executedPayment.state.ToLower() != "approved")
                        {
                            return View("FailureView");
                        }
                        else
                        {
                            int total = 0;
                            foreach (var cartItem in (List<CartItemModel>)Session["cart"])
                            {
                                total = total + (cartItem.productPrice * cartItem.productQuantity);
                            }
                            Models.Order order = new Models.Order();
                            var currentOrderModel = (OrderViewModel)Session["OrderViewModel"];
                            order.FullName = currentOrderModel.Fullname;
                            order.Phone = currentOrderModel.PhoneNumber;
                            order.Email = currentOrderModel.Email;
                            order.ShippingAddress = currentOrderModel.ShippingAddress;
                            order.Total = total;
                            order.PaymentMethod = (string)Session["Paymentmethod"];
                            order.CreatedDate = DateTime.Now;
                            db.Orders.Add(order);
                            db.SaveChanges();
                            int orderID = db.Orders.OrderByDescending(i => i.CreatedDate).Select(i => i.OrderID).First();
                            foreach (var item in (List<CartItemModel>)Session["cart"])
                            {
                                OrderDetail orderDetail = new OrderDetail();
                                orderDetail.OrderID = orderID;
                                orderDetail.ProductID = item.productID;
                                orderDetail.Quantity = item.productQuantity;
                                orderDetail.UnitPrice = item.productPrice;
                                orderDetail.TotalUnit = item.productPrice * item.productQuantity;
                                db.OrderDetails.Add(orderDetail);
                                var productColor = db.ProductColors.Where(i => (i.ProductID == item.productID) && (i.ColorName == item.productColor)).First();
                                int updateColorQuantity = productColor.QuantityInStock.Value - item.productQuantity;
                                productColor.QuantityInStock = updateColorQuantity;
                                db.Entry(productColor).State = EntityState.Modified;
                            }
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    return View("PaymentFailure");
                }
                return View("PaymentSuccess");
            }
            else if (paymentMethod == "CashOnDelivery") {
                Session["cart"] = null;
                return View("CashOnDelivery");
            }
            return View();
        }

        public Payment CreatePayment(APIContext apiContext, string redirectUrl, List<CartItemModel> cartList)
        {
            int total = 0;
            var itemList = new ItemList() { items = new List<Item>() };

            foreach (var cartItem in cartList)
            {
                Item item = new Item();
                item.name = cartItem.productName;
                item.currency = "USD";
                item.price = (cartItem.productPrice * cartItem.productQuantity).ToString();
                item.quantity = cartItem.productQuantity.ToString();
                total = total + (cartItem.productPrice * cartItem.productQuantity);
                itemList.items.Add(item);
            }

            var payer = new Payer() { payment_method = "paypal" };

            // Configure Redirect Urls here with RedirectUrls object
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl,
                return_url = redirectUrl
            };

            var amount = new Amount()
            {
                currency = "USD",
                total = total.ToString()
            };

            var transactionList = new List<Transaction>();

            transactionList.Add(new Transaction()
            {
                description = "Transaction description.",
                invoice_number = GetRandomInvoiceNumber(),
                amount = amount,
                item_list = itemList
            });

            payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };

            return payment.Create(apiContext);
        }

        public Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution() { payer_id = payerId };
            payment = new Payment() { id = paymentId };
            return payment.Execute(apiContext, paymentExecution);
        }

        public static string GetRandomInvoiceNumber()
        {
            return new Random().Next(999999).ToString();
        }
        // GET: Products/Details/5
        public ActionResult AdminDetails(int? id)
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
        public ActionResult AdminCreate()
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
        public ActionResult AdminEdit(int? id)
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

        public bool AddComment(string jsonString) {
            try
            {
                CommentModel model = JsonConvert.DeserializeObject<CommentModel>(jsonString);
                Comment comment = new Comment();
                comment.UserID = model.userID;
                comment.ProductID = model.productID;
                comment.Comment1 = model.commentContent;
                comment.CreatedDate = DateTime.Now;
                db.Comments.Add(comment);
                db.SaveChanges();
                return true;
            }
            catch (Exception e) {
                e.Message.ToString();
            }
            return false;
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminEdit([Bind(Include = "ProductID,CategoryID,ManufacturerID,ProductName,BasisPrice,SellingPrice,CreatedAt")] Product product)
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
        public ActionResult AdminDelete(int? id)
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
        public ActionResult AdminDeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
