using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Static_Ornek
{
    static class EmailHelper
    {
        public static void MailGonder(Email email)
        {
            Console.WriteLine( "From: {0} - To : {1} - Title : {2} - Body : {3}",email._From,email._To,email._Title,email._Body);
        }
    }
}
