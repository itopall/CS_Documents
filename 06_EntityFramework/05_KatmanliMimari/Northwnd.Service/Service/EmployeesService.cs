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
    public interface IEmployeesService
    {
        List<EmployeesDto> GetAll();
        EmployeesDto GeyById(int id);
        void Add(EmployeesDto dto);
        void Update(EmployeesDto dto);
        void Delete(int id);
        EmployeesDto Login(string username);
    }

    public class EmployeesService : IEmployeesService
    {
        //AutoMapper aşağıdaki mapleme işlemlerini tek satırda çözmeye yarayan bir eklentidir!
        public List<EmployeesDto> GetAll()
        {
            List<EmployeesDto> result = new List<EmployeesDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeesRepository.GetAll().ToList();

                result = list.Select(p => new EmployeesDto
                {
                    EmployeeID = p.EmployeeID,
                    FirstName = p.FirstName,
                    LastName = p.LastName
                }).ToList();
            }

            return result;
        }

        public EmployeesDto GeyById(int id)
        {
            EmployeesDto result = new EmployeesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeesRepository.GetById(id);

                result = new EmployeesDto
                {
                    EmployeeID = entity.EmployeeID,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName
                };
            }

            return result;
        }

        public void Add(EmployeesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Employees
                {
                    EmployeeID = dto.EmployeeID,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName
                };

                uow.EmployeesRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(EmployeesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeesRepository.GetById(dto.EmployeeID);

                entity.EmployeeID = dto.EmployeeID;
                entity.FirstName = dto.FirstName;
                entity.LastName = dto.LastName;

                uow.EmployeesRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeesRepository.GetById(id);
                
                uow.EmployeesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public EmployeesDto Login(string username)
        {
            EmployeesDto result = new EmployeesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeesRepository.GetAll(p=> p.FirstName == username).FirstOrDefault();

                if (entity == null)
                {
                    return null;
                }

                result = new EmployeesDto
                {
                    EmployeeID = entity.EmployeeID,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName
                };
            }

            return result;
        }
    }
}