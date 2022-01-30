using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Employee;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETrade.UI.BackEnd.Session
{
    public static class SessionHelper
    {
        public static EmployeeDto ActiveUser
        {
            get
            {
                return (EmployeeDto)HttpContext.Current.Session["AktifKullanici"];
            }
            set
            {
                HttpContext.Current.Session["AktifKullanici"] = value;
            }
        }
    }
}