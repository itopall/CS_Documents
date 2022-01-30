using _01_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_PartialView.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> ProductListe = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Monitor", IsCampaign = true, IsInBasket = false },
            new ProductModel { Id = 2, Name = "Klavye", IsCampaign = false, IsInBasket = true },
            new ProductModel { Id = 3, Name = "Laptop", IsCampaign = true, IsInBasket = true}
        };

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            var model = new ProductListModel();
            model.ProductList = ProductListe;

            return View(model);
        }

        public ActionResult CampaignList()
        {
            var model = new ProductListModel();
            model.ProductList = ProductListe.Where(p=>p.IsCampaign == true).ToList();

            return View(model);
        }

        public ActionResult BasketList()
        {
            var model = new BasketModel();
            model.NameSurname = "Rüştü Dinç";

            model.SepettekiUrunler = new ProductListModel();
            model.SepettekiUrunler.ProductList = ProductListe.Where(p => p.IsInBasket == true).ToList();

            return View(model);
        }
    }
}