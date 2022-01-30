using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Account;
using ETrade.Dto.Dto.Employee;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IEmployeeService
    {
        List<EmployeeDto> GetAll();
        List<EmployeeDto> GetActives();
        EmployeeDto GetById(int id);
        void Add(EmployeeDto dto);
        void Update(EmployeeDto dto);
        void Delete(int id);
        EmployeeDto Login(LoginDto model);
        List<EmployeeDto> Search(EmployeeSearchDto model);
    }

    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDto> GetAll()
        {
            List<EmployeeDto> result = new List<EmployeeDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeeRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Employee, EmployeeDto>).ToList();
            }
        }

        public List<EmployeeDto> GetActives()
        {
            List<EmployeeDto> result = new List<EmployeeDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeeRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<Employee, EmployeeDto>).ToList();
            }
        }

        public EmployeeDto GetById(int id)
        {
            EmployeeDto result = new EmployeeDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeRepository.GetById(id);

                return MapperFactory.Map<Employee, EmployeeDto>(entity);
            }
        }

        public void Add(EmployeeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeDto, Employee>(dto);

                uow.EmployeeRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(EmployeeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeDto, Employee>(dto);

                uow.EmployeeRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeRepository.GetById(id);

                uow.EmployeeRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public EmployeeDto Login(LoginDto model)
        {
            EmployeeDto result = new EmployeeDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeRepository.GetAll(p=> (p.Username == model.UsernameOrEmail || p.Email == model.UsernameOrEmail) && p.Password == model.Password && p.IsActive == true).FirstOrDefault();

                return MapperFactory.Map<Employee, EmployeeDto>(entity);
            }
        }

        public List<EmployeeDto> Search(EmployeeSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeeRepository.GetAll();

                if (model.EmployeeTypeId != null)
                {
                    list = list.Where(p=> p.EmployeeTypeId == model.EmployeeTypeId);
                }

                if (model.ManagerEmployeeId != null)
                {
                    list = list.Where(p => p.ManagerEmployeeId == model.ManagerEmployeeId);
                }

                if (!string.IsNullOrEmpty(model.Namesurname))
                {
                    list = list.Where(p => p.Namesurname.Contains(model.Namesurname));
                }

                if (!string.IsNullOrEmpty(model.Username))
                {
                    list = list.Where(p => p.Username.Contains(model.Username));
                }

                if (!string.IsNullOrEmpty(model.Email))
                {
                    list = list.Where(p => p.Email.Contains(model.Email));
                }

                if (!string.IsNullOrEmpty(model.Phone))
                {
                    list = list.Where(p => p.Phone.Contains(model.Phone));
                }

                var result = list.ToList();

                return result.Select(MapperFactory.Map<Employee, EmployeeDto>).ToList();
            }
        }
    }
}
