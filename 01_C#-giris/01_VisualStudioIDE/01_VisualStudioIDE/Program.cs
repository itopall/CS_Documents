using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using bloğunun görevi, tiplerin kısa isimlerini(namespace'e bildirmeden) yazarak kullanma imkanı sağlamasıdır.

namespace _01_VisualStudioIDE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hahaha");
            //DataTable dt = new DataTable();
            //using bloğuna System.Data'yı eklemezsek her kullanımda aşağıdaki şekilde yazmamız gerekir.
            System.Data.DataTable dt = new System.Data.DataTable();

            //Kodalrın arasına notlar yazabilmek için// ifadesi kullanılır.
            // Bu kısmın koda etkisi yoktur
            /*  
              yorum satırı
              yorum Satırı
              bir yorum satırı daha
            */
            #region Kullanıcı oluşturma bölümü
            //kullanıcı oluşturma adım 1
            //kullanıcı oluşturma adım 2
            //kullanıcı oluşturma adım 3
            //kullanıcı oluşturma adım 4
            //kullanıcı oluşturma adım 5
            //kullanıcı oluşturma adım 6
            #endregion
#warning Warning bloğu daha sonra düzeltmek için uyarı notları almanızı sağlar.
#warning Bu kısım kötü yazılmış daha sonra revizyon yapılabilir.

            // TODO: Task list'e eklemek istediğimiz notları bu şekilde yapabiliriz.Task List penceresini View menüsü altında açabiliriz.
            // ctrl+k+d ile dağılan kod bloklarını tek seferde düzenleyebiliriz.

            // yararlı kaynaklar
            //https://msdn.microsoft.com
            //https://stackoverflow.com
            //https://codeproject.com
            //https://c-sharpcorner.com
            //https://borakasmer.com
            //https://burakselimsenyurt.com

            Console.ReadKey();
        }
    }
}
