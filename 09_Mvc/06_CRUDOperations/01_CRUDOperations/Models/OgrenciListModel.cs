using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_CRUDOperations.Models
{
    public class OgrenciListModel
    {
        public List<OgrenciModel> OgrenciListesi { get; set; }

        //İhtiyaç duyarsak Listeleme sayfasına özel yeni property'ler ekleyebiliriz.
        //public string Message { get; set; }
    }
}