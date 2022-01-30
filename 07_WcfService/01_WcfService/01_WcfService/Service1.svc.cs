using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using _01_WcfService.Dto;

namespace _01_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region Wcf'in default olarak oluşturduğu örnek methodların implementasyonu
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        #endregion

        #region Kendi yazdığımız methodların implementasyonu
        //public List<ProductDto> GetProducts()
        //{
        //    return new List<ProductDto>
        //    {
        //        new ProductDto { Id = 1, Name = "Laptop", Price = 10000},
        //        new ProductDto { Id = 2, Name = "Klavye", Price = 200},
        //        new ProductDto { Id = 3, Name = "Mouse", Price = 100},
        //        new ProductDto { Id = 4, Name = "Monitor", Price = 1200},
        //    };
        //}

        public List<ProductDto> GetProducts(string fromCompany, string password)
        {
            //Log 
            Console.Write($"{fromCompany} İsimli firma {DateTime.Now} tarihinde GetProducts methodunu çağırdı.");

            //Chek
            string dbCheckCompany = string.Empty;
            string dbCheckPassword = string.Empty;
            if (fromCompany != dbCheckCompany || password != dbCheckPassword)
            {
                return null;
            }

            return new List<ProductDto>
            {
                new ProductDto { Id = 1, Name = "Laptop", Price = 10000},
                new ProductDto { Id = 2, Name = "Klavye", Price = 200},
                new ProductDto { Id = 3, Name = "Mouse", Price = 100},
                new ProductDto { Id = 4, Name = "Monitor", Price = 1200},
            };
        }
        #endregion

        //IIS: Bütün web sitelerinin ve web servislerin yayınlandığı işletim sisteminin içinde bulunan bir program. 
        //IIS programını açabilmek için Başlat/Çalıştır/inetmgr yazıp enter'a basabiliriz.
    }
}
