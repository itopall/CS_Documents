using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OperatorleriAsiriYuklemek
{
    enum LogItemPriority
    {
        High,
        Normal,
        Low
    }

    class LogItem
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public LogItemPriority Priority { get; set; }

        public LogItem(int id, string message, DateTime date, LogItemPriority priority)
        {
            Id = id;
            Message = message;
            Date = date;
            Priority = priority;
        }

        //string değişkene yapılan bilinçsiz atama, Örnek string s = new LogItem(...);
        public static implicit operator string(LogItem item)
        {
            return string.Format("{0} - {1}", item.Id.ToString(), item.Message);
        }

        //(TimeSpan) cast işlemi yapıldığında gerçekleşen atamayı kodladık.
        public static explicit operator TimeSpan(LogItem item)
        {
            return DateTime.Now - item.Date;
        }

        //(int) cast işlemi yapıldığında gerçekleşen atamayı kodladık.
        public static explicit operator int(LogItem item)
        {
            return item.Id;
        }

        public static LogItem operator ++(LogItem logItem)
        {
            logItem.Date = logItem.Date.AddDays(1);
            return logItem;
        }

        public static LogItem operator --(LogItem logItem)
        {
            logItem.Date = logItem.Date.AddDays(-1);
            return logItem;
        }

        public static LogItem operator +(LogItem logItem, int sayi)
        {
            logItem.Date = logItem.Date.AddDays(sayi);
            return logItem;
        }

        public static LogItem operator -(LogItem logItem, int sayi)
        {
            logItem.Date = logItem.Date.AddDays(-sayi);
            return logItem;
        }
    }
}
