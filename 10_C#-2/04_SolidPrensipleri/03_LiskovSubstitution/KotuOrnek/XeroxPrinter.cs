using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.KotuOrnek
{
    class CanonPrinter : BasePrinter
    {
        public void Scan(string value)
        {
            Console.WriteLine("Scanned: {0}", value);
        }
    }
}
