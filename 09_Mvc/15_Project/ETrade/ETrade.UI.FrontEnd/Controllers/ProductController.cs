using ETrade.Dto.Dto.FrontEndHome;
using ETrade.Dto.Dto.Product;
using ETrade.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.FrontEnd.Controllers
{
    public class ProductController : BaseController
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int? categoryId)
        {
            var model = new ProductListDto();

            if (categoryId != null)
            {
                model.Products = _productService.GetActivesByCategoryId(categoryId.Value);
            }
            else
            {
                model.Products = _productService.GetActives();
            }

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = new ProductDto();

            model = _productService.GetById(id);

            return View(model);
        }
    }
}