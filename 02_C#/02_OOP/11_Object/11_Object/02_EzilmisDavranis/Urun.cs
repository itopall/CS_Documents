using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EzilmisDavranis
{
    class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Urun(int id, string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            //aşağıdaki yorum satırı Object tipindeki davranışı çalıştırır.
            //return base.ToString();

            return Id + " " + Name + " " + Price; 
        }
        
        public override int GetHashCode()
        {
            //return base.GetHashCode();

            //iki string'in aynı olmalrı durumunda hash kodları da aynıdır.
            //Ürünün tüm bilgileri string olarak birleştirip bu string'in hashcode'una döndük
            //Dolayısıyla bilgileri aynı olan iki ürün aynı string'i oluşturur ve hshcode üretilir.
            return (Id.ToString() + Name + Price.ToString()).GetHashCode();
        }
        //Equals methodunun içinde hashcode karşılaştırması yapmakta fayda vardır. Çünkü hashcodu'un amacı sayısallaştırmaktır. Equals içinde her iki nesne de sayısallaştırılıp bu oluşan değerler karşılaştırılır. 
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);

            return this.GetHashCode() == obj.GetHashCode();
        }
    }
}
