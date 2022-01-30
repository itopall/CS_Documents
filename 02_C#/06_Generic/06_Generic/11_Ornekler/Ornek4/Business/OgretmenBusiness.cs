using _11_Ornekler.Ornek4.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler.Ornek4.Business
{
    class OgretmenBusiness
    {
        List<OgretmenDto> OgretmenListesi { get; set; }

        public OgretmenBusiness()
        {
            OgretmenListesi = new List<OgretmenDto>();
        }
        
        public Sonuc<bool> Ekle(OgretmenDto Ogretmen)
        {
            Sonuc<bool> sonuc = new Sonuc<bool>();
            try
            {
                OgretmenListesi.Add(Ogretmen);

                sonuc.BasariliMi = true;
                sonuc.Mesaj = "İşlem başarıyla tamamlandı...";
                sonuc.Data = true;
                return sonuc;
            }
            catch (Exception ex)
            {
                sonuc.BasariliMi = false;
                sonuc.Mesaj = string.Format("Hata oluştu! Hata detayı : {0}", ex.Message);
                sonuc.Data = false;
                return sonuc;
            }
        }

        public Sonuc<bool> Sil(OgretmenDto Ogretmen)
        {
            Sonuc<bool> sonuc = new Sonuc<bool>();
            try
            {
                OgretmenListesi.Remove(Ogretmen);

                sonuc.BasariliMi = true;
                sonuc.Mesaj = "İşlem başarıyla tamamlandı...";
                sonuc.Data = true;
                return sonuc;
            }
            catch (Exception ex)
            {
                sonuc.BasariliMi = false;
                sonuc.Mesaj = string.Format("Hata oluştu! Hata detayı : {0}", ex.Message);
                sonuc.Data = false;
                return sonuc;
            }
        }

        public Sonuc<List<OgretmenDto>> ListeyiGetir()
        {
            Sonuc<List<OgretmenDto>> sonuc = new Sonuc<List<OgretmenDto>>();
            try
            {
                //throw new Exception("Db'ye bağlanırken hata oluştu! Sunucuya erişilemedi!");

                sonuc.BasariliMi = true;
                sonuc.Mesaj = "İşlem başarıyla tamamlandı...";
                sonuc.Data = OgretmenListesi;
                return sonuc;
            }
            catch (Exception ex)
            {
                sonuc.BasariliMi = false;
                sonuc.Mesaj = string.Format("Hata oluştu! Hata detayı : {0}", ex.Message);
                sonuc.Data = null;
                return sonuc;
            }
        }
    }
}
