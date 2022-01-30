using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.BasketDetail;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IBasketDetailService
    {
        List<BasketDetailDto> GetAll();
        List<BasketDetailDto> GetActives();
        BasketDetailDto GetById(int id);
        void Add(BasketDetailDto dto);
        void Update(BasketDetailDto dto);
        void Delete(int id);
        List<BasketDetailDto> Search(BasketDetailSearchDto model);
        List<BasketDetailDto> GetByBasketId(int basketId);
        void DeleteByProductIdBasketId(int productId, int basketId);
    }

    public class BasketDetailService : IBasketDetailService
    {
        public List<BasketDetailDto> GetAll()
        {
            List<BasketDetailDto> result = new List<BasketDetailDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketDetailRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<BasketDetail, BasketDetailDto>).ToList();
            }
        }

        public List<BasketDetailDto> GetActives()
        {
            List<BasketDetailDto> result = new List<BasketDetailDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketDetailRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<BasketDetail, BasketDetailDto>).ToList();
            }
        }

        public BasketDetailDto GetById(int id)
        {
            BasketDetailDto result = new BasketDetailDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketDetailRepository.GetById(id);

                return MapperFactory.Map<BasketDetail, BasketDetailDto>(entity);
            }
        }

        public void Add(BasketDetailDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<BasketDetailDto, BasketDetail>(dto);

                uow.BasketDetailRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(BasketDetailDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<BasketDetailDto, BasketDetail>(dto);

                uow.BasketDetailRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketDetailRepository.GetById(id);

                uow.BasketDetailRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<BasketDetailDto> Search(BasketDetailSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketDetailRepository.GetAll();

                //if (!string.IsNullOrEmpty(model.Name))
                //{
                //    list = list.Where(p => p.Name.Contains(model.Name));
                //}

                var result = list.ToList();

                return result.Select(MapperFactory.Map<BasketDetail, BasketDetailDto>).ToList();
            }
        }

        public List<BasketDetailDto> GetByBasketId(int basketId)
        {
            List<BasketDetailDto> result = new List<BasketDetailDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketDetailRepository.GetAll(p => p.IsActive == true && p.BasketId == basketId).ToList();
                return list.Select(MapperFactory.Map<BasketDetail, BasketDetailDto>).ToList();
            }
        }

        public void DeleteByProductIdBasketId(int productId, int basketId)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketDetailRepository.GetAll(p=> p.ProductId == productId && p.BasketId == basketId).FirstOrDefault();

                uow.BasketDetailRepository.Delete(entity);
                uow.SaveChanges();
            }
        }
    }
}
