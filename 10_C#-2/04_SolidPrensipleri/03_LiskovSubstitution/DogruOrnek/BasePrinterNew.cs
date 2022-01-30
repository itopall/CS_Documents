using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.DogruOrnek
{
    class BasePrinterNew
    {
        public void Print(string value)
        {
            Console.WriteLine("Printed: {0}", value);
        }
    }
}
