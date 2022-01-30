using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    //Strcutlar classtan inherit edilmezler.
    struct Doctor//:Employee
    {
        //Field tanımlaması yapabiliyoruz.
        public int DoctorId;
        public string TC;
        public int Age;
        //Parametresiz constructor kullanamayız.
        //public Doctor()
        //{
        //}
        //parametresiz constor tanımlayabliriz.
        //Struclar da bütün yapıcı metotların parametre alma zorunluluğu vardır.
        //Yapıcı metot bildirildiği zaman yapının bütün elemanlarına ilk değer verme zorunluluğu vardır.
        public Doctor(int doctorıd,string tc,int age)
        {
            DoctorId = doctorıd;
            TC = tc;
            Age = age;
        }
        //overload constructor
        public Doctor(int doctorıd)
        {
            DoctorId = doctorıd;
            //parametre vermediğimiz alanları da burada ilk değerlerini vermemiz gerekmektedir
            TC = "123467899";
            Age = 25;
        }
        public void bilgiYazdir()
        {
            Console.WriteLine("Doktor id:{0} - TC: {1} - Age:{2}", DoctorId, TC, Age);
        }
    }
}
