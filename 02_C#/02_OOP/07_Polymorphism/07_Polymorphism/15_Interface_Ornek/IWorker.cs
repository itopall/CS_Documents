using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    interface IWorker
    {
        //interface içerisinde field tanımlayamıyoruz
        //string saat;


        // interface içerisinde property tanımlayabiliriz.
         int saat { get; set; }//kaç saat çalıştığını tuttuğumuz property(özellik)

        //çalışan, iş yerinde çalışır.
        void Work(int saat);
    }
}
