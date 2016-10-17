using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EcommerceProject.Models;
using EcommerceProject.ViewModel;
using System.Data.Entity.Validation;
using System.Security.Claims;

namespace EcommerceProject.Controllers
{
    public class UsersController : Controller
    {
        private EcommerceDBEntities db = new EcommerceDBEntities();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Login() {
            ViewBag.returnUrl = Request.UrlReferrer.ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin user, string returnURL, string page)
        {
            if (ModelState.IsValid)
            {
                EncryptData encrypt = new EncryptData();
                string encryptedPassword = encrypt.EncryptPassword(user.Password);
                var userTest = db.Users.Where(i => i.Email == user.Email && i.Password == encryptedPassword).SingleOrDefault();
                if (userTest != null) {
                    Session["UserID"] = userTest.UserID;
                    Session["Username"] = userTest.UserName;
                    if (page == "register") {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(returnURL);
                }
            }
            ModelState.AddModelError(string.Empty, "Your email or password is wrong, please check again.");
            ViewBag.returnURL = returnURL;
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff() {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        // GET: Users/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegister user)
        {
            if (ModelState.IsValid)
            {
                if (CheckDuplicate(user.Email)) {
                    EncryptData encypt = new EncryptData();
                    string encryptedPassword = encypt.EncryptPassword(user.Password);
                    try
                    {
                        User newUser = new Models.User();
                        newUser.UserName = user.UserName;
                        newUser.Password = encryptedPassword;
                        newUser.Email = user.Email;
                        newUser.Role = 1;
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        Session["UserID"] = user.UserID;
                        Session["Username"] = user.UserName;
                    }
                    catch (DbEntityValidationException ex)
                    {
                        Exception raise = ex;
                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                // raise a new exception nesting  
                                // the current instance as InnerException  
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "You email is duplicated, please choose another email address");
            return View(user);
        }

        public bool CheckDuplicate(string emailCheck) {
            var email = db.Users.Where(i => i.Email == emailCheck).SingleOrDefault();
            if (email == null) {
                return true;
            }
            return false;
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,UserName,Password,Email,Phone,Role")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
