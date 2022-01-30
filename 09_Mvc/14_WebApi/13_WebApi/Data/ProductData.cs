using _13_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_WebApi.Data
{
    public static class ProductData
    {
        public static List<ProductModel> Products = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Monitör", Price = 1000, PersonelId = 1 },
            new ProductModel { Id = 2, Name = "Mouse", Price = 100, PersonelId = 2 },
            new ProductModel { Id = 3, Name = "Laptop", Price = 15000, PersonelId = 3 },
            new ProductModel { Id = 4, Name = "Kulaklık", Price = 120, PersonelId = 1 },
        };
    }
}