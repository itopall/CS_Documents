using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static_Ornek
{
    static class EmailHelper
    {
        //Static tanımlanmış class içerisinde sadece static üyeler tanımlanır.
        public static string _From { get; set; }
        public static string _To { get; set; }
        public static string _Title { get; set; }
        public static string _Body { get; set; }
        public static void MailGonder(string from,string to,string title,string body)
        {
            _From = from;
            _To = to;
            _Title = title;
            _Body = body;
            Console.WriteLine("Metot çağırıldığında from'dan To'ya title başlıklı body gövdeli mail gönderildi."+Environment.NewLine+"From: {0} - To : {1} - Title : {2} - Body : {3}",from,to,title,body);
        }
    }
}
