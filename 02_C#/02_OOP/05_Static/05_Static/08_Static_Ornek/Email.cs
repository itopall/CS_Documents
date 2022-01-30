using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Static_Ornek
{
    class Email
    {
        public  string _From { get; set; }
        public  string _To { get; set; }
        public  string _Title { get; set; }
        public  string _Body { get; set; }
        public Email(string from,string to, string title,string body)
        {
            _From = from;
            _To = to;
            _Title = title;
            _Body = body;
        }
    }
}
