using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OperatorleriAsiriYuklemek
{
    class Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Cizgi operator + (Nokta n1, Nokta n2)
        {
            return new Cizgi(n1, n2);
        }
    }
}
