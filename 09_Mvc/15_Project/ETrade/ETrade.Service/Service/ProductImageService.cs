using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
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
    public interface IProductImageService
    {
        List<ProductImageDto> GetAll();
        List<ProductImageDto> GetActives();
        ProductImageDto GetById(int id);
        void Add(ProductImageDto dto);
        void Update(ProductImageDto dto);
        void Delete(int id);
        List<ProductImageDto> Search(ProductImageSearchDto model);
    }

    public class ProductImageService : IProductImageService
    {
        public List<ProductImageDto> GetAll()
        {
            List<ProductImageDto> result = new List<ProductImageDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductImageRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
            }
        }

        public List<ProductImageDto> GetActives()
        {
            List<ProductImageDto> result = new List<ProductImageDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductImageRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
            }
        }

        public ProductImageDto GetById(int id)
        {
            ProductImageDto result = new ProductImageDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductImageRepository.GetById(id);

                return MapperFactory.Map<ProductImage, ProductImageDto>(entity);
            }
        }

        public void Add(ProductImageDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductImageDto, ProductImage>(dto);

                uow.ProductImageRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(ProductImageDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductImageDto, ProductImage>(dto);

                uow.ProductImageRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductImageRepository.GetById(id);

                uow.ProductImageRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<ProductImageDto> Search(ProductImageSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductImageRepository.GetAll();

                if (!string.IsNullOrEmpty(model.FileName))
                {
                    list = list.Where(p => p.FileName.Contains(model.FileName));
                }

                if (!string.IsNullOrEmpty(model.FileType))
                {
                    list = list.Where(p => p.FileType.Contains(model.FileType));
                }

                var result = list.ToList();

                return result.Select(MapperFactory.Map<ProductImage, ProductImageDto>).ToList();
            }
        }
    }
}
