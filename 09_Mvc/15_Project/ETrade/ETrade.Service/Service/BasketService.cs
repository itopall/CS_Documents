using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Basket;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IBasketService
    {
        List<BasketDto> GetAll();
        BasketDto GetById(int id);
        void Add(BasketDto dto);
        void Update(BasketDto dto);
        void Delete(int id);
        List<BasketDto> Search(BasketSearchDto model);
        BasketDto GetByMemberId(int memberId);
    }

    public class BasketService : IBasketService
    {
        public List<BasketDto> GetAll()
        {
            List<BasketDto> result = new List<BasketDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Basket, BasketDto>).ToList();
            }
        }

        public BasketDto GetById(int id)
        {
            BasketDto result = new BasketDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketRepository.GetById(id);

                return MapperFactory.Map<Basket, BasketDto>(entity);
            }
        }

        public void Add(BasketDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<BasketDto, Basket>(dto);

                uow.BasketRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(BasketDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<BasketDto, Basket>(dto);

                uow.BasketRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketRepository.GetById(id);

                uow.BasketRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<BasketDto> Search(BasketSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.BasketRepository.GetAll();

                //if (!string.IsNullOrEmpty(model.Name))
                //{
                //    list = list.Where(p => p.Name.Contains(model.Name));
                //}

                var result = list.ToList();

                return result.Select(MapperFactory.Map<Basket, BasketDto>).ToList();
            }
        }

        public BasketDto GetByMemberId(int memberId)
        {
            BasketDto result = new BasketDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.BasketRepository.GetAll(p=> p.MemberId == memberId).FirstOrDefault();

                return MapperFactory.Map<Basket, BasketDto>(entity);
            }
        }
    }
}
