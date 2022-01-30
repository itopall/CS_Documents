using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OperatorleriAsiriYuklemek
{
    class SatisElemani
    {
        public string AdSoyad { get; set; }
        public int SatisAdedi { get; set; }
        public TimeSpan Sure { get; set; }

        public SatisElemani(string adSoyad, int satisAdedi, TimeSpan sure)
        {
            AdSoyad = adSoyad;
            SatisAdedi = satisAdedi;
            Sure = sure;
        }

        #region +, - Operatörleri
        public static int operator + (SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi + e2.SatisAdedi;
        }

        public static int operator +(SatisElemani e1, int adet)
        {
            return e1.SatisAdedi + adet;
        }

        public static int operator -(SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi - e2.SatisAdedi;
        }

        public static int operator -(SatisElemani e1, int adet)
        {
            return e1.SatisAdedi - adet;
        }
        #endregion

        #region ==, != Operatörleri
        public static bool operator ==(SatisElemani e1, SatisElemani e2)
        {
            return e1.Equals(e2);
        }

        public static bool operator !=(SatisElemani e1, SatisElemani e2)
        {
            return !e1.Equals(e2);
        }

        //İki nesnenin GetHashCode'ları aynılarsa, bu nesneler aynı kabul edilir.
        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            //GetHasCode() methodundan geriye, nesnenin karşılaştırılması sırasında kullanılacak Tam Sayısal bir değer döndürülür.
            return this.SatisAdedi;
        }
        #endregion

        #region <,>, <=, >= Operatörleri
        public static bool operator >(SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi > e2.SatisAdedi;
        }

        public static bool operator <(SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi < e2.SatisAdedi;
        }

        public static bool operator >=(SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi >= e2.SatisAdedi;
        }

        public static bool operator <=(SatisElemani e1, SatisElemani e2)
        {
            return e1.SatisAdedi <= e2.SatisAdedi;
        }
        #endregion
    }
}
