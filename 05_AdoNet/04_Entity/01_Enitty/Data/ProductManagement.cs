using _01_Enitty.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Enitty.Data
{
    class ProductManagement
    {
        private SqlConnection _conn { get; set; }
        private SqlCommand _cmd { get; set; }

        public ProductManagement()
        {
            _conn = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=Northwnd;integrated security=true;");
            _cmd = _conn.CreateCommand();
        }

        public List<ProductEntity> GetProducts()
        {
            try
            {
                _cmd.CommandText = "SELECT * FROM Products";
                _conn.Open();

                List<ProductEntity> products = new List<ProductEntity>();

                SqlDataReader dr = _cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductEntity product = new ProductEntity();
                    product.ProductId = (int)dr["ProductId"];
                    product.ProductName = (string)dr["ProductName"];
                    product.CategoryId = dr["CategoryId"] != DBNull.Value ? (int)dr["CategoryId"] : 0;
                    product.UnitPrice = dr["UnitPrice"] != DBNull.Value ? (decimal)dr["UnitPrice"] : 0;

                    product.ProductFullName = ((int)dr["ProductId"]).ToString() + " - " + (string)dr["ProductName"];

                    products.Add(product);
                }

                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
