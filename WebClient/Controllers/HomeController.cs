using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;




namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ECommerce";
            ViewBag.Message = "Welcome to ECommerce!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //[HttpPost]
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            ViewBag.Message = "Login into your account.";
            return View();
        }

        [HttpPost]
        public ActionResult Login(WCFService.User user)
        {
            var login = Database.Instance.UserProxy.FindUserByCredentials(user.Username, user.Password);
            if (login != null)
            {
                Session["uid"] = login.Id;
            }
            return View();
        }

        //[HttpPost]
        public ActionResult Register()
        {
            ViewBag.Title = "Register";
            ViewBag.Message = "Register an account.";
            return View();
        }

        [HttpPost]
        public ActionResult Register(WCFService.User user)
        {
            ViewBag.Title = "Register";
            ViewBag.Message = "Register an account.";

            var register = Database.Instance.UserProxy.Insert(user);

            if (register == true)
                ViewBag.Information = "User registered.";
            else
                ViewBag.Warning = "Cannot register user";

            return View();
        }

        public ActionResult Logout()
        {
            ViewBag.Title = "Logout";
            ViewBag.Message = "";

            Session["uid"] = null;

            return View();
        }

        public ActionResult User()
        {
            ViewBag.Title = "Edit user";
            ViewBag.Message = "Edit your account.";

            if (Session["uid"] != null)
            {
                int userId = (int)Session["uid"];
                var data = Database.Instance.UserProxy.FindUserById(userId);
                return View(data);
            }
            return View();
        }

        [HttpPost]
        public ActionResult User(WCFService.User user)
        {
            ViewBag.Title = "Edit user";
            ViewBag.Message = "Edit your account.";

            if (Session["uid"] != null)
            {
                int userId = (int)Session["uid"];
                var data = Database.Instance.UserProxy.FindUserById(userId);
                data.Username = user.Username;
                data.Email = user.Email;
                var update = Database.Instance.UserProxy.Edit(data);
                return View(user);
            }
            return View();
        }

    }
}