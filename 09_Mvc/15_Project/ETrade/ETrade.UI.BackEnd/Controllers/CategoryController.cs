using ETrade.Dto.Dto.Employee;
using ETrade.Dto.Dto.Category;
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
    public class CategoryController : BaseController
    {
        public ICategoryService _categoryService;
        public IProductService _productService;
        public CategoryController(ICategoryService categoryService,
                                IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Kategori Yönetimi";

            var model = new CategorySearchDto();

            model.Categories = _categoryService.GetAll();

            return View(model);
        }

        [HttpPost]
        public ActionResult Search(CategorySearchDto model)
        {
            model.Categories = _categoryService.Search(model);

            var list = HtmlHelpers.RenderRazorViewToString(ControllerContext, "~/Views/Category/_List.cshtml", model);

            return Json(new { status = true, list = list, message = "İşlem başarıyla tamamlandı...", JsonRequestBehavior.AllowGet });
        }

        public ActionResult AddEdit(int? id)
        {
            ViewBag.PageTitle = "Kategori Ekleme/Güncelleme";

            var model = new CategoryDto();

            if (id != null)
            {
                model = _categoryService.GetById(id.Value);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(CategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            if (dto.Id > 0)
            {
                dto.UpdatedDate = DateTime.Now;
                dto.UpdatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _categoryService.Update(dto);
            }
            else
            {
                dto.CreatedDate = DateTime.Now;
                dto.CreatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _categoryService.Add(dto);
            }

            TempData["ResultMessage"] = "İşlem başarıyla tamamlandı...";

            return RedirectToAction("Index", "Category");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                int count = _productService.GetProductCountByCategoryId(id);
                if (count > 0)
                {
                    TempData["ErrorMessage"] = "Bu kategori'ye bağlı aktif kullanılan ürün ya da ürünler olduğundan silme işlemi gerçekleştirilemez!";

                    return RedirectToAction("Index", "Category");
                }

                _categoryService.Delete(id.Value);
            }

            return RedirectToAction("Index", "Category");
        }
    }
}