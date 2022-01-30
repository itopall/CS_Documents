using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    class Product
    {
        //Id ve Price field'ları private olduğu için nesne kullanıcısı bu field'ları derekt erişim sağlayamaz.Erişim sağlamak için aşağıda tanımlanan public durumundaki kapsül methodları kullanılmak zorundadır.
        //kapsül methodların görevi private field'lara erişimleri kontrol altına alarak değerlerin kontrollü şekilde okunmasını ve yazılmasını sağlamaktadır.
        private int id;
        private double price;

        public int get_id()
        {
            return id;
        }
        public void set_id(int yeniDeger)
        {
            if (yeniDeger > 10000)
                throw new ArgumentException("Id değeri 1-10000 arasında olmalıdır!");
            id = yeniDeger;
        }

        //get_price methodunun amacı sadece private bir field olan price2ın sakladığı değeri okumak(nesne kullanıcısına iletmek)tir
        public double get_price()
        {
            return price;
        }
        //set_price methodunun amacı nesne kullanıcısının private durumdaki price field'ına kontrollü bir şekilde değer atamasını sağlamaktadır.Bu örnekte uyguladığımız validasyon ile price değerinin 0'dan küçük girilmemesini garanti altına almış olduk.Böylelikle fiyatı 0 olan bir ürün olmayacak.
        public void set_price(int yeniDeger)
        {
            if (yeniDeger <= 0)
            {
                throw new ArgumentException("geçersiz bir fiyat girdiniz! Fiyat sıfırdan büyük olmalıdır.");
            }
            price = yeniDeger;
        }
    }
}
