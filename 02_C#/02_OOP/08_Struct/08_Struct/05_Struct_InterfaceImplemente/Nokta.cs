using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Struct_InterfaceImplemente
{
    struct Nokta : IDeneme //Deneme bir class old. için strucları classlardan inherit edemiyoruz.
    {
        public int _x { get; set; }
        public int _y { get; set; }
        public void dene()
        {
            Console.WriteLine("Dene metodu çalıştı.");
        }
        public void Test()
        {
            Console.WriteLine("Test metodu çalıştı.");
        }
        //Bir struct'ın constructor'ı ya kendisi ya da yönlendirdiği constructor tarafından fieldlara ilk değerlerini atamalıdır.
        public Nokta(int x,int y):this()
        {
            _x = x;
            _y = y;
        }
    }
}
