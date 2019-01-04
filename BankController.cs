using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay1Assignment1.Controllers
{
    public class BankController : Controller
    {
       public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string LoginID, string Password)
        {
            if (LoginID == "user1" && Password == "pass@123")
            {
                Session["loginid"] = LoginID;
                return RedirectToAction("Index", "Bank");
            }
            else
            {
                ViewBag.msg = "Invalid ID or Password";
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUser(string EmailID,string Password,string FullName,string City,string MobileNo)
        {
            return View("View_CustomerCreated");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Bank");
        }
    }
}