using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Employee;
using ETrade.Dto.Dto.Member;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETrade.UI.FrontEnd.Session
{
    public static class SessionHelper
    {
        public static MemberDto ActiveUser
        {
            get
            {
                return (MemberDto)HttpContext.Current.Session["AktifKullanici"];
            }
            set
            {
                HttpContext.Current.Session["AktifKullanici"] = value;
            }
        }
    }
}