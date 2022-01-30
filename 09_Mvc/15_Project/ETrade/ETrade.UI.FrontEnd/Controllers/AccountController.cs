using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Account;
using ETrade.Service.Service;
using ETrade.UI.FrontEnd.Session;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ETrade.UI.FrontEnd.Controllers
{
    public class AccountController : Controller
    {
        public IEmployeeService _employeeService { get; }
        public IMemberService _memberService { get; }

        public AccountController(IEmployeeService employeeService,
                                IMemberService memberService)
        {
            _employeeService = employeeService;
            _memberService = memberService;
        }

        public ActionResult Login()
        {
            ViewBag.PageTitle = "Login";

            var model = new LoginDto();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginDto model)
        {
            //var employeeDto = _employeeService.Login(model);
            var dto = _memberService.Login(model);

            if (dto == null)
            {
                model.ErrorMessage = "Kullanıcı Adı/Email ya da şifre hatalı!";
                return View(model);
            }

            SessionHelper.ActiveUser = dto;
            Session.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["SessionTimeoutTime"]);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
    }
}