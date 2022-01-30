using ETrade.Dto.Dto.Employee;
using ETrade.Dto.Dto.Product;
using ETrade.Service.Service;
using ETrade.UI.BackEnd.Attribute;
using ETrade.UI.BackEnd.Helper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Controllers
{
    [UserAuthorize]
    public class ProductController : BaseController
    {
        public IProductService _productService;
        public ICategoryService _categoryService;
        public ISupplierService _supplierService;
        public ProductController(IProductService productService,
                                ICategoryService categoryService,
                                ISupplierService supplierService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _supplierService = supplierService;
        }

        public ActionResult Index(string name)
        {
            ViewBag.PageTitle = "Ürün Yönetimi";

            var model = new ProductSearchDto();

            if (!string.IsNullOrEmpty(name))
            {
                model.Products = _productService.Search(new ProductSearchDto { Name = name });
            }
            else
            {
                model.Products = _productService.GetAll();
            }
            
            model.CategoryList = _categoryService.GetActives();
            model.SupplierList = _supplierService.GetActives();

            return View(model);
        }

        [HttpPost]
        public ActionResult Search(ProductSearchDto model)
        {
            model.Products = _productService.Search(model);

            var list = HtmlHelpers.RenderRazorViewToString(ControllerContext, "~/Views/Product/_List.cshtml", model);

            return Json(new { status = true, list = list, message = "İşlem başarıyla tamamlandı...", JsonRequestBehavior.AllowGet });
        }

        public ActionResult AddEdit(int? id)
        {
            ViewBag.PageTitle = "Ürün Ekleme/Güncelleme";

            var model = new ProductDto();

            if (id != null)
            {
                model = _productService.GetById(id.Value);
            }

            model.CategoryList = _categoryService.GetActives();
            model.SupplierList = _supplierService.GetActives();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(ProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                dto.CategoryList = _categoryService.GetActives();
                dto.SupplierList = _supplierService.GetActives();

                return View(dto);
            }

            if (dto.Id > 0)
            {
                dto.UpdatedDate = DateTime.Now;
                dto.UpdatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _productService.Update(dto);
            }
            else
            {
                dto.CreatedDate = DateTime.Now;
                dto.CreatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _productService.Add(dto);
            }

            TempData["ResultMessage"] = "İşlem başarıyla tamamlandı...";

            return RedirectToAction("Index", "Product");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _productService.Delete(id.Value);
            }

            return RedirectToAction("Index", "Product");
        }
    }
}