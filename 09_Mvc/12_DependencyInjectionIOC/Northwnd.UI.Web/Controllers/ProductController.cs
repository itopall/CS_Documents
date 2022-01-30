using Northwnd.Service.Services;
using Northwnd.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.UI.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IPersonelService _personelService;
        public ProductController(IProductService productService, IPersonelService personelService)
        {
            _productService = productService;
            _personelService = personelService;
        }

        // GET: Product
        public ActionResult Index()
        {
            //IProductService productService = new ProductService();
            //productService.GetAll();

            _productService.GetAll();
            _personelService.GetAll();

            return View();
        }

        public ActionResult Detail()
        {
            //IProductService productService = new ProductService();
            //productService.GetById(1);

            _productService.GetById(1);
            _personelService.GetById(1);

            return View();
        }
    }
}