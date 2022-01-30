using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface_DiamondProblemicin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerden de İnsstance, nesne üretemiyoruz.
            //Aşağıdaki şekilde newlersek hata alırız.
            //IYuruyebilir yuru = new IYuruyebilir()

            Balik balik = new Balik();
            balik.Yuz();

            Kus kus = new Kus();
            kus.Uc();
            kus.Yuru();

            Insan insan = new Insan();
            insan.Yuru();
            insan.Yuz();

            //IYuruyebilir interfacesini implemente ettiği için insan tipinden üretilen nesneyi yuruyenNesne ' ye vermiş oluyoruz.
            IYuruyebilir yuruyenNesne = new Insan();
            yuruyenNesne.Yuru();

            IYuruyebilir yuruyenNesne2 = new Kus();
            yuruyenNesne2.Yuru();

            IYüzebilir yuzenNesne = new Balik();
            yuzenNesne.Yuz();

            IYüzebilir yuzenNesne2 = new Insan();
            yuzenNesne2.Yuz();

            IUcabilir ucanNesne = new Kus();
            ucanNesne.Uc();

            //IUcabilir Interface'ini implemente ettiği için Kus tipinde nesneyi metoda parametre olarak yazdık.
            Ucur(new Kus());

            Yuru(new Insan());

            Yuzdur(new Insan());

            Yuru(new Kus());

            Yuzdur(new Balik());


            Console.ReadKey();
        }
        static void Ucur(IUcabilir ucabilir)
        {
            ucabilir.Uc();
        }

        static void Yuzdur(IYüzebilir yuzebilir)
        {
            yuzebilir.Yuz();
        }

        static void Yuru(IYuruyebilir yuruyebilir)
        {
            yuruyebilir.Yuru();
        }
    }
}
