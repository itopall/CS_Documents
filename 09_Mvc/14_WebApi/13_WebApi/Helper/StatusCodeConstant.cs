using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_WebApi.Helper
{
    public static class StatusCodeConstant
    {
        public const string IslemBasarili  = "İşlem başarıyla tamamlandı";
        public const string LoginBasarisiz = "Login işlemi başarısız! Kullanıcı adı ya da şifre hatalı";
        public const string DataNotFound = "Kayıt bulunamadı!";
        public const string KayitEklerkenHataOlustu = "Insert aşamasında hata oluştu!";
        public const string KayitGuncellerkenHataOlustu = "Güncelleme aşamasında hata oluştu!";
        public const string KayitSilerkenkenHataOlustu = "Silme aşamasında hata oluştu!";
        public const string ValidasyonHatasi = "Gönderdiğiniz model validasyon kurallanrına uygun değil!";
    }
}