using _03_WcfClient_IISVersion.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WcfClient_IISVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            List<ProductDto> list = client.GetProducts().ToList();

            foreach (var p in list)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadKey();
        }
    }
}
