using ETrade.Dto.Dto.Employee;
using ETrade.Dto.Dto.ProductImage;
using ETrade.Service.Service;
using ETrade.UI.BackEnd.Attribute;
using ETrade.UI.BackEnd.Helper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Controllers
{
    [UserAuthorize]
    public class ProductImageController : BaseController
    {
        public IProductImageService _productImageService;
        public IProductService _productService;
        public ProductImageController(IProductImageService productImageService,
                                IProductService productService)
        {
            _productImageService = productImageService;
            _productService = productService;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Ürün Resim Yönetimi";

            var model = new ProductImageSearchDto();

            model.ProductImages = _productImageService.GetAll();

            return View(model);
        }

        [HttpPost]
        public ActionResult Search(ProductImageSearchDto model)
        {
            model.ProductImages = _productImageService.Search(model);

            var list = HtmlHelpers.RenderRazorViewToString(ControllerContext, "~/Views/ProductImage/_List.cshtml", model);

            return Json(new { status = true, list = list, message = "İşlem başarıyla tamamlandı...", JsonRequestBehavior.AllowGet });
        }

        public ActionResult AddEdit(int? id)
        {
            ViewBag.PageTitle = "Ürün Resim Ekleme/Güncelleme";

            var model = new ProductImageDto();

            if (id != null)
            {
                model = _productImageService.GetById(id.Value);
            }

            model.ProductList = _productService.GetActives();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(ProductImageDto dto, IEnumerable<HttpPostedFileBase> uploadFiles) //IEnumerable<HttpPostedFile> ile birden fazla resim eklenmesini sağlayabiliriz.
        {
            if (!ModelState.IsValid)
            {
                dto.ProductList = _productService.GetActives();

                return View(dto);
            }

            var fileName = string.Empty;
            var extension = string.Empty;
            foreach (var file in uploadFiles)
            {
                if (file != null && file.ContentLength > 0)
                {
                    if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg")
                    {
                        var fi = new FileInfo(file.FileName);

                        fileName = Guid.NewGuid().ToString() + fi.Extension;
                        extension = fi.Extension;

                        //var path = Path.Combine(Server.MapPath("~/Files/images/"), fileName);
                        var path = Path.Combine("C:/ImageLoader/ETradeFtp/SharedImages/", fileName);

                        file.SaveAs(path);
                    }
                }
            }

            dto.FileName = fileName;
            dto.FileType = extension;
            //dto.ImageUrl = "C:/ETradeFtp/SharedImages/" + fileName;
            dto.ImageUrl = "http://localhost/ImageLoader/ETradeFtp/SharedImages/" + fileName; //Frontend ve backend aynı yerden image'ları görebilsin diye bu tarz bir yol izledik. 

            if (dto.Id > 0)
            {
                dto.UpdatedDate = DateTime.Now;
                dto.UpdatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _productImageService.Update(dto);
            }
            else
            {
                dto.CreatedDate = DateTime.Now;
                dto.CreatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _productImageService.Add(dto);
            }

            TempData["ResultMessage"] = "İşlem başarıyla tamamlandı...";

            return RedirectToAction("Index", "ProductImage");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _productImageService.Delete(id.Value);
            }

            return RedirectToAction("Index", "ProductImage");
        }
    }
}