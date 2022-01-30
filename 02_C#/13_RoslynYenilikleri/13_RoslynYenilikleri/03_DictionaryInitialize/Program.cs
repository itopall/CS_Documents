using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DictionaryInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Artıık Dictionary'lere aşağıdaki şekilde tanımlama anında değer atması yapabiliyoruz.
            Dictionary<string, string> dictionaryStr = new Dictionary<string, string>
            {
                ["Adi"] = "Rüştü",
                ["Soyadi"] = "DİNÇ",
                ["Yasi"] = "26",
            };

            dictionaryStr["Meslek"] = "İş Analisti";
            dictionaryStr["kurum"] = "Albaraka";


            Dictionary<int, string> dictionaryInt = new Dictionary<int, string>
            {
                [1] = "Rüştü",
                [2] = "DİNÇ",
                [3] = "26",
            };

            dictionaryInt[4] = "İş Analisti";
            dictionaryInt[5] = "Albaraka";

            Console.ReadKey();
        }
    }
}
