using ETrade.Service.Service;
using ETrade.UI.BackEnd.Attribute;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Controllers
{
    [UserAuthorize]
    public class MemberController : BaseController
    {
        public IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Üye Yönetimi";

            //throw new Exception("manuel hata");
            return View();
        }
    }
}