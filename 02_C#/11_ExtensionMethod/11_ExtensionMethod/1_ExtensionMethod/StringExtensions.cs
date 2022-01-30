using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ExtensionMethod
{
    public static class StringExtensions
    {
        public static string RemoveNumeric(this string str)
        {
            //str: "deneme1234Test456"
            //return: "denemeTest"


            string sonuc = string.Empty;

            foreach (var c in str)
            {
                if (!char.IsNumber(c))
                {
                    sonuc += c;
                }
            }


            return sonuc;
        }
    }
}
