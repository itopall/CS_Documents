using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.DogruOrnek
{
    class XeroxPrinterNew : BasePrinterNew, IScan
    {
        public void Scan(string value)
        {
            Console.WriteLine("Scanned: {0}", value);
        }
    }
}
