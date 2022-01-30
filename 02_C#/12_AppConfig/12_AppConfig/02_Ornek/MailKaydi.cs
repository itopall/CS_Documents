using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek
{
    class MailKaydi<T>
    {
        public T AliciAdres { get; set; }
        public T MailTipi { get; set; }
        public T Baslik { get; set; }
        public T Icerik { get; set; }
        public MailKaydi(T aliciAdres, T mailTipi, T baslik, T icerik)
        {
            AliciAdres = aliciAdres;
            MailTipi = mailTipi;
            Baslik = baslik;
            Icerik = icerik;
        }

        
    }
}
