using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Enum
{
    public enum PurchaseOrderStatusEnum
    {
        SiparisVerildi = 1,
        UrunHazirlaniyor = 2,
        KargoyaVerildi = 3,
        YolaCikti = 4,
        TeslimEdildi = 5,
        IadeEdildi = 6,
        IadeSureciTamamlandi = 7
    }
}
