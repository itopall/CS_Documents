using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct, yapıları olarak adlandırılır
            //C dilinde programlama yapan programcılar çok fazla kullanılır.
            //Java dilinde struct yoktur.

            //yapılar C# dişlinde değer tipi(int, double vs.)olan verilerdir.
            //Yapı bildirimi, class bildirimi ile benzemektedir.
            //class keyword'ü yerine struct keyword'ü kullanılarak oluşturulur.

            //Nesnelere referans yoluyla erişmek bazı durumlarda avantajlı olmayabilir.
            //Bİrbiri ile ilişkili az sayıda değişkeni bir sınıf içinde tutmak bellek kullanımı açısından pek yararlı olmayacaktır.
            //REferans tipleri için hem heap bölgesinde sınıfın üye elemanları için alan tahsis ediliyordu, hemde referans değeri tutumak için stack bölgesinde alan tahsis edilir.

            //İnheritance mantığı olmadığı için C#'ta pek tercih edilmez.
            //Yapılar değer tipi oldukları için yapı türünden nesneler stack bellek bölgesinde saklanır.
            //yapı nesnelerin faaliyet alanları bittiğinde otomatik olarak stack bölgesinde silinirler.
            //Yıkıcı metotlar yoktur.Zaten otoma

            Doctor doctor1 = new Doctor(1, "232154687", 34);
            doctor1.bilgiYazdir();

            Doctor doctor2 = new Doctor(2);
            doctor2.bilgiYazdir();

            Doctor doctor3 = new Doctor();
            doctor3.DoctorId = 3;
            doctor3.TC = "154879314";
            doctor3.Age = 45;
            doctor3.bilgiYazdir();
            

            Console.ReadKey();
        }
    }
}
