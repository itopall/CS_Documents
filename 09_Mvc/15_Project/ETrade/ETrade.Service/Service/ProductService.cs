using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Product;
using ETrade.Dto.Dto.ProductImage;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        List<ProductDto> GetActives();
        ProductDto GetById(int id);
        void Add(ProductDto dto);
        void Update(ProductDto dto);
        void Delete(int id);
        List<ProductDto> Search(ProductSearchDto model);
        int GetProductCountByCategoryId(int? categoryId);
        int? GetTotalClickedCount();
        List<ProductDto> GetActivesByCategoryId(int categoryId);
    }

    public class ProductService : IProductService
    {
        public List<ProductDto> GetAll()
        {
            List<ProductDto> result = new List<ProductDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Product, ProductDto>).ToList();
            }
        }

        public List<ProductDto> GetActives()
        {
            List<ProductDto> result = new List<ProductDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductRepository.GetAll(p => p.IsActive == true); //.ToList();
                
                result = list.Select(MapperFactory.Map<Product, ProductDto>).ToList();

                foreach (var product in result)
                {
                    var productImageList = list.Where(p=> p.Id == product.Id).FirstOrDefault().ProductImage;
                    product.ProductImage = productImageList.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
                }
            }
            return result;
        }

        public ProductDto GetById(int id)
        {
            ProductDto result = new ProductDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductRepository.GetById(id);

                result = MapperFactory.Map<Product, ProductDto>(entity);
                result.ProductImage = entity.ProductImage.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
            }
            return result;
        }

        public void Add(ProductDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductDto, Product>(dto);

                uow.ProductRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(ProductDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductDto, Product>(dto);

                uow.ProductRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductRepository.GetById(id);

                uow.ProductRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<ProductDto> Search(ProductSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductRepository.GetAll();

                if (model.CategoryId != null)
                {
                    list = list.Where(p => p.CategoryId == model.CategoryId);
                }

                if (model.SupplierId != null)
                {
                    list = list.Where(p => p.SupplierId == model.SupplierId);
                }

                if (!string.IsNullOrEmpty(model.Name))
                {
                    list = list.Where(p => p.Name.Contains(model.Name));
                }

                if (model.InPriceStart != null && model.InPriceStart > 0)
                {
                    list = list.Where(p => p.InPrice >= model.InPriceStart);
                }

                if (model.InPriceEnd != null && model.InPriceEnd > 0)
                {
                    list = list.Where(p => p.InPrice <= model.InPriceEnd);
                }

                if (model.OutPriceStart != null && model.OutPriceStart > 0)
                {
                    list = list.Where(p => p.OutPrice >= model.OutPriceStart);
                }

                if (model.OutPriceEnd != null && model.OutPriceEnd > 0)
                {
                    list = list.Where(p => p.InPrice <= model.OutPriceEnd);
                }

                var result = list.ToList();

                return result.Select(MapperFactory.Map<Product, ProductDto>).ToList();
            }
        }

        public int GetProductCountByCategoryId(int? categoryId)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.ProductRepository.GetAll(p => p.IsActive == true && p.CategoryId == categoryId).Count();
            }
        }

        public int? GetTotalClickedCount()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.ProductRepository.GetAll(p => p.IsActive == true).Sum(p=> p.ClickedCount);
            }
        }

        public List<ProductDto> GetActivesByCategoryId(int categoryId)
        {
            List<ProductDto> result = new List<ProductDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductRepository.GetAll(p => p.IsActive == true && p.CategoryId == categoryId); //.ToList();

                result = list.Select(MapperFactory.Map<Product, ProductDto>).ToList();

                foreach (var product in result)
                {
                    var productImageList = list.Where(p => p.Id == product.Id).FirstOrDefault().ProductImage;
                    product.ProductImage = productImageList.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
                }
            }
            return result;
        }
    }
}
