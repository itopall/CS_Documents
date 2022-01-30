using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40 };
            double[] ondaliklar = { 10.2, 20.2, 30.2, 40.2 };
            short[] kucukSayilar = { 1, 2, 3, 4 };
            bool[] durumlar = { true, false, true, false };

            Int32DiziBoyutlandir(ref sayilar, 10);
            DoubleDiziBoyutlandir(ref ondaliklar, 10);
            ShortDiziBoyutlandir(ref kucukSayilar, 10);
            BoolDiziBoyutlandir(ref durumlar, 10);

            GenericDiziBoyutlandir<int>(ref sayilar, 20);
            GenericDiziBoyutlandir<double>(ref ondaliklar, 20);
            GenericDiziBoyutlandir(ref kucukSayilar, 20); //T'yi söylemesek de olur
            GenericDiziBoyutlandir(ref durumlar, 20);

            Console.ReadKey();
        }

        //int[] ve yeniBoyut parametresi alarak, diziyi yeniden boyutlandıran method.
        static void Int32DiziBoyutlandir(ref int[] dizi, int yeniBoyut)
        {
            int[] yeniDizi = new int[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }

        static void DoubleDiziBoyutlandir(ref double[] dizi, int yeniBoyut)
        {
            double[] yeniDizi = new double[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }

        static void ShortDiziBoyutlandir(ref short[] dizi, int yeniBoyut)
        {
            short[] yeniDizi = new short[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }

        static void BoolDiziBoyutlandir(ref bool[] dizi, int yeniBoyut)
        {
            bool[] yeniDizi = new bool[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }

        //Generic method ile yukarıda yazılan 4 methodu tek bir methodda yazıp farklı tipler için çalışmasını sağladık.
        static void GenericDiziBoyutlandir<T>(ref T[] dizi, int yeniBoyut)
        {
            T[] yeniDizi = new T[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }
    }
}
