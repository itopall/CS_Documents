using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Method_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //1: Kullanıcıdan bir sayı girmesini isteyerek girilen sayının iki katını alıp ekrana yazdıran programı yazalım.
            //istenen();

            //2)= birden 100 e kadar olan tek sayıların ekrana yazdıran methodu yazalım
            //Birdenyuze();

            //3)=parametre olarak aldığı sayının küpünün ekrana yazdıran methodu yazalım
            //Kup(3);

            //4)= parametre olarak aldığı 2 sayının çarpımını ekrana yazdıran program
            //IkiSayiCarp(8213, 214);

            //5)= Parametre olarak aldığı 3 adet string parametreyi aralara '-' atarak  birleştrip ekrana yazdıran methodu yazalım
            //TireAt("ilker", "topal", "amasya");

            //6)= parametre olarak aldığı isim,soyisim ve numara bilgilerini yan yana aralarda boşluk olcak şekilde birleştirip geri dönen methodu yazalım.Geri dönen değeri ekrana yazdıralım
            //Console.WriteLine(KisiBilgileri("ilker", "Topal", 546662112));

            //7)= parametre olarak aldığı int dizisinin içerisindeki en büyük değeri bulup geri dönen methodu yazalım.Geri dönen değeri ekrana yazalım.
            //int[] sayilar = { 12, 465, 378 };
            //Console.WriteLine(Enbuyuk(sayilar));
            //tek satırda kullanım
            //Console.WriteLine("enbüyük: {0}", Enbuyuk(new int[] { 1, 2, 3, 4, 78 }));// kullanılabilir

            //8)= Parametre olarak aldığı int dizisinin ortlamasını bulup geri dönen methodu yazalım.
            //int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Ortalama(sayilar));

            //9)= Parametre olarak aldığı 2 adet string dizisini birleştirip yeni dizi olarak dönen methodu yazalım
            string[] kelimeler1 = { "ilker","topal" };
            string[] kelimeler2 = { "merhaba","nasılsın" };
            string[] sonuc = Birlestirme(kelimeler1, kelimeler2);
            foreach (string kelime in sonuc)
            {
                Console.WriteLine(kelime);
            }
            

            Console.ReadKey();
        }
        static void Istenen()
        {
            Console.Write("sayı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", s1 * 2);
        }

        static void Birdenyuze()
        {
            for(int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void Kup(int sayi)
        {
            Console.WriteLine("küp: {0}",Math.Pow(sayi, 3));
        }

        static void IkiSayiCarp(int sayi1, int sayi2)
        {
            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sayi1 * sayi2);
        }

        static void TireAt(string bir,string iki,string üç)
        {
            Console.WriteLine("{0} - {1} - {2}", bir, iki, üç);
        }
        
        static string KisiBilgileri(string isim ,string soyisim ,int numara)
        {
           
            //return  isim +" "+soyisim+" "+ numara ;
            return string.Format("{0} {1} {2}", isim, soyisim, numara);
        }

        static int Enbuyuk(int[] dizi)
        {
           return dizi.Max();
        }

        static double Ortalama(int[] dizi)
        {
            return dizi.Average();
        }

        static string[] Birlestirme(string[] dizi1, string[] dizi2)
        {
            return dizi1.Concat(dizi2).ToArray();;
        }



    }
}
