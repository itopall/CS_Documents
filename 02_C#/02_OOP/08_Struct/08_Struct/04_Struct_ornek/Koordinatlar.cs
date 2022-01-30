using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Struct_ornek
{
    struct Koordinatlar
    {
        //kullkanım 1 için 
        //public int x;
        //public int y;
        //public Koordinatlar(int _x,  int _y)
        //{
        //    x = _x;
        //    y = _y;
            
        //}


        //İlk değer atamalı kullanım 2 
        public static int _x = 10;
        public static int _y = 20;
        //kullanım 2 için yapıcı
        public Koordinatlar(int a,int b)
        {
            _x = a;
            _y = b;
        }
      
    }
}
