using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataTable Oluşturmak
            //Herhangi bir veri kaynağındaki kayıtları ya da sonuç satırlarını, ürettiğimiz bir DataTable nesnesinde saklayabiliriz.

            DataTable datatable = new DataTable("Products");

            //Bir datacolumn nesnesi oluşturup DataTable'a ekleme
            DataColumn column1 = new DataColumn("ProductId", typeof(int));
            datatable.Columns.Add(column1);

            //DataColumn ekleme 2. yöntem
            datatable.Columns.Add("ProductCategoryId", typeof(int));
            datatable.Columns.Add("ProductName", typeof(string));
            datatable.Columns.Add("UnitPrice", typeof(decimal));
            #endregion

            #region DataTable'a satır ekleme
            //datatable.NewRow methodu, oluşturduğumuz tablonun şemasına uygun bir satır üretir ve geri döner. Bu dönen satır üzerine değer atamalarını yapabiliriz.
            DataRow row = datatable.NewRow();
            row[0] = 1;
            row[1] = 2;
            row[2] = "Laptop";
            row[3] = 10000;

            //Bir DataRow nesnesi datatable'ın Rows koleksiyonuna eklenmediği sürece tabloya eklenmiş olmaz!
            datatable.Rows.Add(row);

            //DataRow ekleme 2. yöntem
            datatable.Rows.Add(2, 2, "Klavye", 100);
            #endregion

            #region DataTable ve Foreach Kullanımı
            //DataRow değerlerini index numarası vererek ya da sütun ismi vererek kullanabiliriz.
            foreach (DataRow dataRow in datatable.Rows)
            {
                Console.WriteLine($"ProductId: {dataRow[0]}, ProductName: {dataRow["ProductName"]}, UnitPrice: {dataRow["UnitPrice"]} ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
