using Northwnd.Data.Context;
using Northwnd.Data.Repository;
using Northwnd.Data.UnitOfWork;
using Northwnd.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Service.Service.SadeceRepositoryKullanimi
{
    public interface IProductsServiceWithOutUow
    {
        List<ProductsDto> GetAll();
        ProductsDto GeyById(int id);
    }

    //UnitOfWork Kullanmadan sadece Repository'ler üzerinden de kullanım sağlanabilir.
    public class ProductsServiceWithOutUow : IProductsServiceWithOutUow
    {
        public List<ProductsDto> GetAll()
        {
            List<ProductsDto> result = new List<ProductsDto>();

            var productsRepository = new ProductsRepository();
            var list = productsRepository.GetAll().ToList();

            result = list.Select(p => new ProductsDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                SupplierID = p.SupplierID,
                CategoryID = p.CategoryID,
                UnitPrice = p.UnitPrice
            }).ToList();

            return result;
        }

        public ProductsDto GeyById(int id)
        {
            ProductsDto result = new ProductsDto();

            var productsRepository = new ProductsRepository();
            var list = productsRepository.GetAll().ToList();
            var entity = productsRepository.GetById(id);

            result = new ProductsDto
            {
                ProductID = entity.ProductID,
                ProductName = entity.ProductName,
                SupplierID = entity.SupplierID,
                CategoryID = entity.CategoryID,
                UnitPrice = entity.UnitPrice
            };

            return result;
        }
    }
}