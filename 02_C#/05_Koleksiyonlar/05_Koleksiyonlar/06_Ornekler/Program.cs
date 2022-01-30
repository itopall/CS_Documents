using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ornek 1
            //Klavyeden girilen adet bilgisi uzunluğunda bir ArrayList oluşturup içerisini random sayılarla dolduran ve listeye eklenen elemanları daha sonra ekrana yazdıran programı yazalım
            //Console.Write("uzunluk sayısı giriniz: ");
            //int uzunluk = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();

            //ArrayList sayilar = new ArrayList();
            //for (int i = 0; i < uzunluk; i++)
            //{
            //    int sayi = rnd.Next(0,50);
            //    sayilar.Add(sayi);
            //    //sayilar.Add(rnd.Next(0, 50));

            //}
            //foreach (object item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Ornek 2
            //10 karakter uzunluğunda bir ArrayList oluşturup değerlerini atayalım.5. index'ten sonra 2 tane yeni kayıt ekleyelim("yeni gelen 1" "yeni gelen 2" sonra ArrayList'i ters şekilde sıralayıp ilk 5 değeri silip kalanları ekrana yazdıralım.
            //ArrayList ekleme = new ArrayList();
            //ekleme.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //ekleme.Insert(5, "yeni gelen 1");
            //ekleme.Insert(6, "yeni gelen 2");
            //ekleme.Reverse();
            //ekleme.RemoveRange(0, 5);
            //foreach (object item in ekleme)
            //    Console.WriteLine(item);

            //for (int i = 0; i < ekleme.Count; i++)
            //    Console.WriteLine(ekleme[i]);

            #endregion

            #region Ornek 3
            //bir tane 5 karakter uzunluğunda int[] ve yine 5 karakter uzunluğunda ArrayList oluşturalım ve değerlerini atayalım.Bir tane method yazarak iki listeyi de parametre olarak alıp gelen değerin tipi int[] is 2. karakteri Arraylis ise 3. karakteri ekrana yazdıralım.
            int[] sayilar = { 1, 2, 3, 4, 5 };
            ArrayList list = new ArrayList(new object[] { "iler", "merhaba", 1, 3, 4 });
            YAzdir(sayilar);
            YAzdir(list);
            #endregion

            #region Ornek 4
            //Bir tane MailSablon adında class oluşturalım içerisnde Id,From,To ve Content property'leri olsun.Sonra bu class üzerinden 3 farklı nesne üretip bir listeye ekleyelim ve bu listeden mailler FIFO kuralına uygun olarak gönderilsin.
            Queue queue = new Queue();
            MailSablon mail1 = new MailSablon(1,"blabla@gmail.com","slalsa@gmail.com","merhaba");
            MailSablon mail2 = new MailSablon(2, "huhuh@gmail.com", "klo@gmail.com", "iyi");
            MailSablon mail3 = new MailSablon(2, "subsub@gmail.com", "zalle@gmail.com", "sen");

            queue.Enqueue(mail1);
            queue.Enqueue(mail2);
            queue.Enqueue(mail3);
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                MailSablon result = (MailSablon)queue.Dequeue();
                Console.WriteLine("{0} kullanıcısı {1} kullanıcısına mail gönderdi",result.From,result.To);
            }
            #endregion

            #region örnek 5
            ArrayList ogrenciListe = new ArrayList();
            ogrenciListe.Add("Rumeysa");
            ogrenciListe.Add("Rüştü");
            ogrenciListe.Add("Berat");
            ogrenciListe.Add("Sefa");
            ogrenciListe.Add("İlker");

            //1.Adım
            Console.Write("Yeni öğrenci adı giriniz: ");
            ogrenciListe.Add(Console.ReadLine());
            Console.WriteLine("Yeni öğrenci başarıyla eklendi..");

            //2.Adım
            Console.Write("Sorgulamak istediğiniz öğrenci adını giriniz: ");
            if (ogrenciListe.Contains(Console.ReadLine()))
                Console.WriteLine("Aradığınız öğrenci kaydı listede mevcuttur.");
            else
                Console.WriteLine("Aradığınız öğrenci bulunamadı.");

            //3.Adım
            Console.Write("Güncellemek istediğiniz öğrenci adını giriniz: ");
            string ogrenciAdi = Console.ReadLine();
            int indexof = ogrenciListe.IndexOf(ogrenciAdi);
            if(indexof > -1)
            {
                Console.Write("Yeni isim giriniz: ");
                string ogrenciAdiYeni = Console.ReadLine();
                ogrenciListe[indexof] = ogrenciAdiYeni;
                Console.WriteLine("Öğrenci kaydı başarıyla güncellendi.");
            }
            else
                Console.WriteLine("Güncellemek için aradığınız öğrenci bulunamadı.");

            //4.Adım
            Console.Write("Silmek istediğiniz öğrenci adını giriniz: ");
            string silinecekOgrenci = Console.ReadLine();
            if (silinecekOgrenci.Contains(silinecekOgrenci))
            {
                ogrenciListe.Remove(silinecekOgrenci);
                Console.WriteLine("Öğrenci kaydı başarıyla silinmiştir...");
            }
            else
                Console.WriteLine("Silmek için aradığınız öğrenci bulunamadı..");
            //5.Adım
            foreach (object ogrenci in ogrenciListe)
            {
                Console.WriteLine(ogrenci);
            }

            #endregion

            Console.ReadKey();
        }

        private static void YAzdir(ICollection deger)
        {
            if (deger is ArrayList)
            {
                ArrayList arrayList = (ArrayList)deger;
                Console.WriteLine("3.index: {0}", arrayList[3]);//((ArratList)deger)[3]
            }
            
            if(deger.GetType() == typeof(int[]))//(deger is int[])
            {
                Console.WriteLine("2. index: {0}", ((int[])deger)[2]);
            }
        }
    }
}
