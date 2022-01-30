using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            MaasHesabi ms = new MaasHesabi();
            ms.Bakiye = 1000;
            ms.Set_Id(10);

            Console.ReadKey();
        }
    }

    class MaasHesabi
    {
        private int id;
        private double bakiye;

        public int Get_Id()
        {
            //Yetki kontrolü yapılabilir.
            return id;
        }

        public void Set_Id(int newId)
        {
            //Yetki kontrolü yapılabilir.
            id = newId;
        }

        public double Bakiye
        {
            get
            {
                //Yetki kontrolü yapılabilir.
                return bakiye;
            }
            set
            {
                //Yetki kontrolü yapılabilir.
                bakiye = value;
            }
        }
    }
}
