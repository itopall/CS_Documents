using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ornekler
{
    public static class StringExtensions
    {
        public static string RemoveSpace(this string str)
        {
            //string sonuc = string.Empty;
            //foreach (var c in str)
            //{
            //    if (c != ' ')
            //    {
            //        sonuc += c;
            //    }
            //}

            return str.Replace(" ",""); 
        }
    }
}
