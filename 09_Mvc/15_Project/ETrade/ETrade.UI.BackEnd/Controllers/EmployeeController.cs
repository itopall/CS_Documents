using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Employee;
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
    public class EmployeeController : BaseController
    {
        public IEmployeeService _employeeService;
        public IEmployeeTypeService _employeeTypeService;
        public EmployeeController(IEmployeeService employeeService,
                                    IEmployeeTypeService employeeTypeService)
        {
            _employeeService = employeeService;
            _employeeTypeService = employeeTypeService;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Personel Yönetimi";

            var model = new EmployeeSearchDto();

            var employees = _employeeService.GetAll();

            model.Employees = employees;
            model.EmployeeTypeList = _employeeTypeService.GetActives();
            model.EmployeeList = employees;

            return View(model);
        }

        [HttpPost]
        public ActionResult Search(EmployeeSearchDto model)
        {
            if (model.EmployeeTypeId == null)
            {
                return Json(new { status = false, list = "", message = "Personel Tipi boş bırakılamaz!", JsonRequestBehavior.AllowGet });
            }

            model.Employees = _employeeService.Search(model);

            var list = HtmlHelpers.RenderRazorViewToString(ControllerContext, "~/Views/Employee/_List.cshtml", model);

            return Json(new { status = true, list = list, message = "İşlem başarıyla tamamlandı...", JsonRequestBehavior.AllowGet });
        }

        public ActionResult AddEdit(int? id)
        {
            ViewBag.PageTitle = "Personel Ekleme/Güncelleme";

            var model = new EmployeeDto();

            if (id != null)
            {
                model = _employeeService.GetById(id.Value);
            }

            model.EmployeeTypeList = _employeeTypeService.GetActives();
            model.EmployeeList = _employeeService.GetAll();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(EmployeeDto dto, IEnumerable<HttpPostedFileBase> uploadFiles)
        {
            if (!ModelState.IsValid)
            {
                dto.EmployeeTypeList = _employeeTypeService.GetActives();
                dto.EmployeeList = _employeeService.GetAll();

                return View(dto);
            }

            var fileName = string.Empty;
            foreach (var file in uploadFiles)
            {
                if (file != null && file.ContentLength > 0)
                {
                    if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg")
                    {
                        var fi = new FileInfo(file.FileName);

                        fileName = Guid.NewGuid().ToString() + fi.Extension;

                        var path = Path.Combine(Server.MapPath("~/Files/EmployeeProfileImages/"), fileName);
                        file.SaveAs(path);
                    }
                }
            }

            dto.ImageUrl = "/Files/EmployeeProfileImages/" + fileName;

            if (dto.Id > 0)
            {
                dto.UpdatedDate = DateTime.Now;
                dto.UpdatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _employeeService.Update(dto);
            }
            else
            {
                dto.CreatedDate = DateTime.Now;
                dto.CreatedBy = ETrade.UI.BackEnd.Session.SessionHelper.ActiveUser.Id;

                _employeeService.Add(dto);
            }

            TempData["ResultMessage"] = "İşlem başarıyla tamamlandı...";

            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _employeeService.Delete(id.Value);
            }

            TempData["ResultMessage"] = "İşlem başarıyla tamamlandı...";

            return RedirectToAction("Index", "Employee");
        }
    }
}