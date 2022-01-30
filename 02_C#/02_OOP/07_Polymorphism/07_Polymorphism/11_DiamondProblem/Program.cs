using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //derived class sadece tek bir base classtan inherit alır.Bir class virden fazla classtan inherit alamaz.
            //Inherit alsaydı da, override edilen metotlar hangisini aldığını karıştırır.
            //A adında bir base class var.
            //B,C ve D adındaki derived classlar A classından inherit alır 
            //A classında virtual metot tanımlı.
            //A classında virtual metot tanımlı b classında virtual metodu override ediyoruz.
            //C calssında yine virtual metodu override ediyoruz.
            //D calssında ise C ve B 'den inherit aldığımızı düşünürsek(böyle bir şey yok) hangi metodu kullanacağımızı karıştırır.Bunada DiamondProblem denir.
            //Çoklu kalıtım yapılamadığı için interface yapısı oluşturulmuş
        }
    }
}
