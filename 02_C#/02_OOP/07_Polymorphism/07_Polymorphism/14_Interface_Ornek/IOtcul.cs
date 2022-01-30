using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    //IOtcul interface'i, ICanli interfacesinden implemente edilmiştir.
    //IOtcul interfacesnden implemente edilecek tüm classlar içerisnde, hem IOtcul hemde ICanli interface içerisindeki metotlar override edilebilir.
    interface IOtcul : ICanli
    {
        void BeslenmeSekli();
    }
}
