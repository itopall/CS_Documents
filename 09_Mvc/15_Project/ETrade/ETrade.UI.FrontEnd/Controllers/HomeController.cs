using ETrade.Dto.Dto.FrontEndHome;
using ETrade.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.FrontEnd.Controllers
{
    public class HomeController : BaseController
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public HomeController(IProductService productService,
                            ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var model = new FrontEndHomeDto();

            Session["LayoutMenuCategoryList"] = _categoryService.GetActives();

            model.ProductList = _productService.GetActives();

            return View(model);
        }
    }
}