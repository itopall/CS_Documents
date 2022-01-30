using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ornekler
{
    class MailSablon
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }

        public MailSablon(int id, string from,string to,string content)
        {
            Id = id;
            From = from;
            To = to;
            Content = content;
        }
    }
}
