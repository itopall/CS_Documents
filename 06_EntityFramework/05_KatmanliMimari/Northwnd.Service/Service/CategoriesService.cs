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
    public interface ICategoriesService
    {
        List<CategoriesDto> GetAll();
        CategoriesDto GeyById(int id);
        void Add(CategoriesDto dto);
        void Update(CategoriesDto dto);
        void Delete(int id);
        List<CategoriesDto> GetByName(string name);
    }

    public class CategoriesService : ICategoriesService
    {
        //AutoMapper aşağıdaki mapleme işlemlerini tek satırda çözmeye yarayan bir eklentidir!
        public List<CategoriesDto> GetAll()
        {
            List<CategoriesDto> result = new List<CategoriesDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoriesRepository.GetAll().ToList();

                //Linq Sorgusu ile Dto'ya Çevirme
                result = list.Select(c => new CategoriesDto
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    Picture = c.Picture
                }).ToList();

                //Döngü İle Dto'ya çevirme
                //foreach (var c in list)
                //{
                //    result.Add(new CategoriesDto
                //    {
                //        CategoryID = c.CategoryID,
                //        CategoryName = c.CategoryName,
                //        Description = c.Description,
                //        Picture = c.Picture
                //    });
                //}

                //Eğer AUTOMAPPER kullansaydık!
                //result = mapper.ToMap<List<Categories>, List<CategoriesDto>>(list);
                //list = mapper.ToMap<List<CategoriesDto>, List<Categories>>(result);
            }

            return result;

            //UnitOfWork bu şekilde de kullanılabilirdi.
            //UnitOfWork uow2 = new UnitOfWork();
            //uow2.CategoriesRepository.GetAll();
        }

        public CategoriesDto GeyById(int id)
        {
            CategoriesDto result = new CategoriesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(id);

                result = new CategoriesDto
                {
                    CategoryID = entity.CategoryID,
                    CategoryName = entity.CategoryName,
                    Description = entity.Description,
                    Picture = entity.Picture
                };
            }

            return result;
        }

        public void Add(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Categories
                {
                    CategoryID = dto.CategoryID,
                    CategoryName = dto.CategoryName,
                    Description = dto.Description,
                    Picture = dto.Picture
                };

                uow.CategoriesRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(dto.CategoryID);

                entity.CategoryID = dto.CategoryID;
                entity.CategoryName = dto.CategoryName;
                entity.Description = dto.Description;
                entity.Picture = dto.Picture;

                uow.CategoriesRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(id);
                
                uow.CategoriesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<CategoriesDto> GetByName(string name)
        {
            List<CategoriesDto> result = new List<CategoriesDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoriesRepository.GetAll(p => p.CategoryName.ToUpper().Contains(name.ToUpper())).ToList();

                result = list.Select(c => new CategoriesDto
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    Picture = c.Picture
                }).ToList();
            }

            return result;
        }
    }
}