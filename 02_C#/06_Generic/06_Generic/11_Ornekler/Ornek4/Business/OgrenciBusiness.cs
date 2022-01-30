using _11_Ornekler.Ornek4.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler.Ornek4.Business
{
    class OgrenciBusiness
    {
        List<OgrenciDto> OgrenciListesi { get; set; }

        public OgrenciBusiness()
        {
            OgrenciListesi = new List<OgrenciDto>();
        }
        
        public Sonuc<bool> Ekle(OgrenciDto ogrenci)
        {
            Sonuc<bool> sonuc = new Sonuc<bool>();
            try
            {
                OgrenciListesi.Add(ogrenci);

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

        public Sonuc<bool> Sil(OgrenciDto ogrenci)
        {
            Sonuc<bool> sonuc = new Sonuc<bool>();
            try
            {
                OgrenciListesi.Remove(ogrenci);

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

        public Sonuc<List<OgrenciDto>> ListeyiGetir()
        {
            Sonuc<List<OgrenciDto>> sonuc = new Sonuc<List<OgrenciDto>>();
            try
            {
                //throw new Exception("Db'ye bağlanırken hata oluştu! Sunucuya erişilemedi!");

                sonuc.BasariliMi = true;
                sonuc.Mesaj = "İşlem başarıyla tamamlandı...";
                sonuc.Data = OgrenciListesi;
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
