using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    class Customer
    {
        //Erişim belirleyicileri(acces modifiers),private olduğu zaman sadece bu classtan erişim sağlar.
        private int CustomerId;
        //customer sınıfından ilk değer ataması yaptık, set methodu da olmadığından dışarıdan değer alamaz.
        private string FirstName = "İlker";

        private string LastName;

        //Otomatik encapsulation oluışturduğumuzda get methodu için kendimiz metod tanımladık.
        public int get_CustomerId()//int _customerId// buda kullanılabilir.
        {
            return CustomerId;//_customerId gelir yerine 
        }
        //Otomatik encapsulation oluşturdumuğumuzdaki set methodu için kendimiz method tanımladık
        public void set_CustomerId(int _yeniCustomerId)
        {
            if (_yeniCustomerId > 5000)
                throw new ArgumentException("1-5000 arasında değer olmalıdır.");
            CustomerId = _yeniCustomerId;
        }
        //firstname için get methodunu yazdık set methodu yok
        public string get_FirstName()
        {
            return FirstName;
        }
        //LastName için sadece set methodunu kullandık.Aşağıdaki method dışarıdan veri ataması için kullanılır.
        public void set_LastName(string SonIsim)
        {
            //Dışarıdan gelen değeri(sonIsim) LastName field'ına atadık.
            LastName = SonIsim;
        }

        // her zaman get ve set i beraber kullanmamız gerekmemektedir.
        //ikisini birlikte kullandığımızda oluşturulan field'a hem okuma işlemini yap(get), hem de fielde değer atama işlemini atama işlemini yap demiş oluyoruz.
        //encapsulation işlemi yaparken sadece get methodunu çağırdığımızda dışarıdan sadece okuma işlemi yapabiliriz.

        //Encapsulation işlemi yaparken sadece set methodunu çağırdığımızda da dışarıdan fielde değer ataması yapabiliriz.
    }
}
