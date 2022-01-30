using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Önce nesneyi üretip sonra property'lere atama yöntemi
            Personel personel = new Personel();
            personel.Id = 10;
            personel.NameSurname = "Berat Yurdakul";
            personel.Age = 23;
            personel.Title = "Yazılım Uzmanı";
            
            //Parametre alan ctor ile kullanım
            Personel personel2 = new Personel(11, "İlker Topal", 21, "Yazılım Uzmanı");

            //Object initializer ile kullanma, yukarıdaki kullanımlarla birebir aynıdır.
            Personel personel3 = new Personel
            {
                Id = 12,
                NameSurname = "Rumeysa Koral",
                Age = 23,
                Title = "Yazılım Uzmanı"
            };

            //Collection Initializer
            List<int> list = new List<int>
            {
                1,2,3,4,5,6
            };
            List<Personel> personelListesi = new List<Personel>
            {
                new Personel {Id = 1 , NameSurname = "ali",Age = 21 , Title = "Öğrenci"},
                new Personel {Id = 2 , NameSurname = "veli", Age = 22, Title = "Belirsiz"},
                new Personel {Id = 3 , NameSurname = "metin", Age = 23, Title = "Mezun"}
            };
            foreach (Personel prs in personelListesi)
            {
                Console.WriteLine("Id: {0}\r\nNameSurname: {1}\r\n",prs.Id,prs.NameSurname);
            }

            Console.ReadKey();
        }
    }
    class Personel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }

        public Personel(int id,string nameSurname,int age,string title)
        {
            Id = id;
            NameSurname = nameSurname;
            Age = age;
            Title = title;
        }
        public Personel()
        {

        }
    }
}
