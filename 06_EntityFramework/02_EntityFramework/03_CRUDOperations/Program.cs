using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CRUDOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();

            #region Insert İşlemi
            ////Yöntem 1
            //Shippers shipper1 = new Shippers();
            //shipper1.CompanyName = "InsertTest1";
            //shipper1.Phone = "123456567";
            //var result = context.Shippers.Add(shipper1);
            //context.SaveChanges();
            //Console.WriteLine("Insert işlemi başarılı. Id:{0}", result.ShipperID);

            ////Yöntem 2
            //Shippers shipper2 = new Shippers
            //{
            //    CompanyName = "InsertTest2",
            //    Phone = "987654321"
            //};
            //context.Entry<Shippers>(shipper2).State = System.Data.Entity.EntityState.Added;
            //context.SaveChanges();
            //Console.WriteLine("Insert işlemi başarılı. Id:{0}", shipper2.ShipperID);

            ////Toplu İnsert İşlemi
            //List<Shippers> shipperList = new List<Shippers>
            //{
            //    new Shippers { CompanyName = "InsertTest3", Phone="123123123" },
            //    new Shippers { CompanyName = "InsertTest4", Phone="123123123" },
            //    new Shippers { CompanyName = "InsertTest5", Phone="123123123" }
            //};

            //var result2 = context.Shippers.AddRange(shipperList);
            //context.SaveChanges();
            //foreach (var s in result2)
            //    Console.WriteLine("Toplu Insert işlemi başarılı. Id:{0}", s.ShipperID);
            #endregion

            #region Update İşlemleri
            ////1. Yöntem
            //var shipper3 = context.Shippers.Where(p=> p.ShipperID == 27).FirstOrDefault();
            //shipper3.CompanyName = "UpdateTest1";
            //context.SaveChanges();
            //Console.WriteLine("Update işlemi başarılı. Id: {0}", shipper3.ShipperID);

            //2. Yöntem
            //var shipper4 = context.Shippers.Where(p => p.ShipperID == 28).FirstOrDefault();
            //shipper4.CompanyName = "UpdateTest2";
            //context.Entry(shipper4).State = System.Data.Entity.EntityState.Modified;
            //context.SaveChanges();
            //Console.WriteLine("Update işlemi başarılı. Id: {0}", shipper4.ShipperID);
            #endregion

            #region Delete İşlemleri
            //1. Yöntem
            //var shipper5 = context.Shippers.Where(p => p.ShipperID == 27).FirstOrDefault();
            //context.Shippers.Remove(shipper5);
            //context.SaveChanges();
            //Console.WriteLine("Silme işlemi başarıyla tamamlandı.");

            //2. Yöntem
            //var shipper6 = context.Shippers.Where(p => p.ShipperID == 28).FirstOrDefault();
            //context.Entry(shipper6).State = System.Data.Entity.EntityState.Deleted;
            //context.SaveChanges();
            //Console.WriteLine("Silme işlemi başarıyla tamamlandı.");

            //Toplı Silme İşlemi
            var list = context.Shippers.Where(p => p.CompanyName.Contains("InsertTest")).ToList();
            context.Shippers.RemoveRange(list);
            context.SaveChanges();
            Console.WriteLine("Toplu silme işlemi başarıyla tamamlandı.");
            #endregion

            Console.ReadKey();
        }
    }
}
