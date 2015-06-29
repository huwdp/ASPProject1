using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            var products = Database.Instance.ProductProxy.GetProductList();
            return View(products);
        }

        public ActionResult Product()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Product(int id)
        {
            var product = Database.Instance.ProductProxy.FindProductById(id);
            if (product != null)
                return View(product);
            else
                return View();
        }

        public ActionResult Basket()
        {
            if (Session["uid"] != null)
            {
                int userId = (int)Session["uid"];
                var products = Database.Instance.BasketProxy.FindProductsByUser(userId);

                decimal? total = (decimal?)0;
                foreach (var product in products)
                    total += product.Price;
                ViewBag.Total = total;

                return View(products);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Add(int id)
        {
            if (Session["uid"] != null)
            {
                var data = Database.Instance.BasketProxy.Insert((int)Session["uid"], id);
                if (data)
                    ViewBag.Information = "Product added to basket!";
                else
                    ViewBag.Warning = "Could not add product to basket.";
            }
            return View();
        }

        public ActionResult Visa()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Visa(WCFService.Visa visa)
        {
            if (Session["uid"] != null)
            {
                // Ran out of time to implment the address form
                var data = Database.Instance.OrderProxy.InsertOrderFromUser((int)Session["uid"], new WCFService.Address(), visa);
                if (data)
                    ViewBag.Information = "Order purchased";
                else
                    ViewBag.Warning = "Could not purchase order.";

            }
            return View();
        }
    }
}