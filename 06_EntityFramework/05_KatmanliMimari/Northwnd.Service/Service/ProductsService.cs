using Northwnd.Data.Context;
using Northwnd.Data.UnitOfWork;
using Northwnd.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Service.Service
{
    public interface IProductsService
    {
        List<ProductsDto> GetAll();
        ProductsDto GeyById(int id);
        void Add(ProductsDto dto);
        void Update(ProductsDto dto);
        void Delete(int id);
    }

    public class ProductsService : IProductsService
    {
        //AutoMapper aşağıdaki mapleme işlemlerini tek satırda çözmeye yarayan bir eklentidir!
        public List<ProductsDto> GetAll()
        {
            List<ProductsDto> result = new List<ProductsDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductsRepository.GetAll().ToList();

                result = list.Select(p => new ProductsDto
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    SupplierID = p.SupplierID,
                    CategoryID = p.CategoryID,
                    UnitPrice = p.UnitPrice
                }).ToList();
            }

            return result;
        }

        public ProductsDto GeyById(int id)
        {
            ProductsDto result = new ProductsDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(id);

                result = new ProductsDto
                {
                    ProductID = entity.ProductID,
                    ProductName = entity.ProductName,
                    SupplierID = entity.SupplierID,
                    CategoryID = entity.CategoryID,
                    UnitPrice = entity.UnitPrice
                };
            }

            return result;
        }

        public void Add(ProductsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Products
                {
                    ProductID = dto.ProductID,
                    ProductName = dto.ProductName,
                    SupplierID = dto.SupplierID,
                    CategoryID = dto.CategoryID,
                    UnitPrice = dto.UnitPrice
                };

                uow.ProductsRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(ProductsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(dto.ProductID);

                entity.ProductID = dto.ProductID;
                entity.ProductName = dto.ProductName;
                entity.SupplierID = dto.SupplierID;
                entity.CategoryID = dto.CategoryID;
                entity.UnitPrice = dto.UnitPrice;

                uow.ProductsRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(id);
                
                uow.ProductsRepository.Delete(entity);
                uow.SaveChanges();
            }
        }
    }
}