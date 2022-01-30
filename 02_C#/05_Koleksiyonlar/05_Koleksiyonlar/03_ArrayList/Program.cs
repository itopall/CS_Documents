using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki üretilen ArrayList'in ilk elemanları verildiğinden dolayı, count ve Capacity değerleri aynı olur,(ikisi de 6)
            ArrayList liste = new ArrayList(new int[] { 5, 10, 15, 20, 5, 10 });
            KoleksiyonBilgiVer(liste);
            liste.Add(5);
            KoleksiyonBilgiVer(liste);

            ElemanSayisiYazdir(liste);
            ElemanSayisiYazdir(new object[] { true, DateTime.Now, "deneme" });
            ElemanSayisiYazdir(new int[] { 5, 10, 15, 20, 5, 10 });
            AyristiriciMethod(liste);
            AyristiriciMethod(new int[] { 5, 10, 15, 20 });

            Console.ReadKey();
        }

        private static void KoleksiyonBilgiVer(ArrayList liste)
        {
            Console.WriteLine("Kapasite: {0}, Count: {1}",liste.Capacity,liste.Count);
        }
        //aşağıdaki methodaiICollection olan tüm tipler parametre olarak gönderilebilir.Örnek int[], object[], ArrayList vb.
        //Bu methoda parametre olarak gelen nesne ne olursa olsun ICollection'ı implement ettiğinden dolayı,bu şablona uymaktadır ve mutlaka Count property'si vardır
        static void ElemanSayisiYazdir(ICollection liste)
        {
            Console.WriteLine(liste.Count); 
        }
        static void AyristiriciMethod(ICollection liste)
        {
            Console.WriteLine("Count: {0}",liste.Count);

            //is keyword'ü ile
            if (liste is ArrayList)
            {
                ArrayList arrayList = (ArrayList)liste;
                Console.WriteLine("Capacity: {0}",arrayList.Capacity);
            }
            //typeof ile
            if (liste.GetType() == typeof(int[]))
            {
                ArrayList arrayList = (ArrayList)liste;
                Console.WriteLine("Length: {0}", ((int[])liste).Length);
            }
        }
    }
}
