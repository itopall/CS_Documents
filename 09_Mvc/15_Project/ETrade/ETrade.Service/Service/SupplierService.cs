using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Supplier;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface ISupplierService
    {
        List<SupplierDto> GetAll();
        List<SupplierDto> GetActives();
        SupplierDto GetById(int id);
        void Add(SupplierDto dto);
        void Update(SupplierDto dto);
        void Delete(int id);
        List<SupplierDto> Search(SupplierSearchDto model);
    }

    public class SupplierService : ISupplierService
    {
        public List<SupplierDto> GetAll()
        {
            List<SupplierDto> result = new List<SupplierDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.SupplierRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Supplier, SupplierDto>).ToList();
            }
        }

        public List<SupplierDto> GetActives()
        {
            List<SupplierDto> result = new List<SupplierDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.SupplierRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<Supplier, SupplierDto>).ToList();
            }
        }

        public SupplierDto GetById(int id)
        {
            SupplierDto result = new SupplierDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.SupplierRepository.GetById(id);

                return MapperFactory.Map<Supplier, SupplierDto>(entity);
            }
        }

        public void Add(SupplierDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<SupplierDto, Supplier>(dto);

                uow.SupplierRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(SupplierDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<SupplierDto, Supplier>(dto);

                uow.SupplierRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.SupplierRepository.GetById(id);

                uow.SupplierRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<SupplierDto> Search(SupplierSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.SupplierRepository.GetAll();

                if (!string.IsNullOrEmpty(model.Name))
                {
                    list = list.Where(p => p.Name.Contains(model.Name));
                }

                var result = list.ToList();

                return result.Select(MapperFactory.Map<Supplier, SupplierDto>).ToList();
            }
        }
    }
}
