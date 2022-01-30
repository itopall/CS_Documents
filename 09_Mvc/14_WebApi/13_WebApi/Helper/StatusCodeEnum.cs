using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_WebApi.Helper
{
    public enum StatusCodeEnum : int
    {
        IslemBasarili = 200,
        LoginBasarisiz = 100,
        DataNotFound = 101,
        KayitEklerkenHataOlustu = 102,
        KayitGuncellerkenHataOlustu = 103,
        KayitSilerkenkenHataOlustu = 103,
        ValidasyonHatasi = 104
    }
}