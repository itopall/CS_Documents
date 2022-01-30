using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ornekler
{
    public static class UsAl
    {
        public static int UstAl(this int sayi, int sayi1)
        {
            
            return (int)Math.Pow(sayi, sayi1); ;
        }
    }
}
