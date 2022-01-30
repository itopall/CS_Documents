using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Category;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAll();
        List<CategoryDto> GetActives();
        CategoryDto GetById(int id);
        void Add(CategoryDto dto);
        void Update(CategoryDto dto);
        void Delete(int id);
        List<CategoryDto> Search(CategorySearchDto model);
    }

    public class CategoryService : ICategoryService
    {
        public List<CategoryDto> GetAll()
        {
            List<CategoryDto> result = new List<CategoryDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoryRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Category, CategoryDto>).ToList();
            }
        }

        public List<CategoryDto> GetActives()
        {
            List<CategoryDto> result = new List<CategoryDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoryRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<Category, CategoryDto>).ToList();
            }
        }

        public CategoryDto GetById(int id)
        {
            CategoryDto result = new CategoryDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoryRepository.GetById(id);

                return MapperFactory.Map<Category, CategoryDto>(entity);
            }
        }

        public void Add(CategoryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CategoryDto, Category>(dto);

                uow.CategoryRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(CategoryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CategoryDto, Category>(dto);

                uow.CategoryRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoryRepository.GetById(id);

                uow.CategoryRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<CategoryDto> Search(CategorySearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoryRepository.GetAll();

                if (!string.IsNullOrEmpty(model.Name))
                {
                    list = list.Where(p => p.Name.Contains(model.Name));
                }

                var result = list.ToList();

                return result.Select(MapperFactory.Map<Category, CategoryDto>).ToList();
            }
        }
    }
}
