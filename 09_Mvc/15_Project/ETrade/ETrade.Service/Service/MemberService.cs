using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Account;
using ETrade.Dto.Dto.Member;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IMemberService
    {
        List<MemberDto> GetAll();
        List<MemberDto> GetActives();
        MemberDto GetById(int id);
        void Add(MemberDto dto);
        void Update(MemberDto dto);
        void Delete(int id);
        MemberDto Login(LoginDto model);
    }

    public class MemberService : IMemberService
    {
        public List<MemberDto> GetAll()
        {
            List<MemberDto> result = new List<MemberDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.MemberRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Member, MemberDto>).ToList();
            }
        }

        public List<MemberDto> GetActives()
        {
            List<MemberDto> result = new List<MemberDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.MemberRepository.GetAll(p=> p.IsActive == true).ToList();
                return list.Select(MapperFactory.Map<Member, MemberDto>).ToList();
            }
        }

        public MemberDto GetById(int id)
        {
            MemberDto result = new MemberDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.MemberRepository.GetById(id);

                return MapperFactory.Map<Member, MemberDto>(entity);
            }
        }

        public void Add(MemberDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<MemberDto, Member>(dto);

                uow.MemberRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(MemberDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<MemberDto, Member>(dto);

                uow.MemberRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.MemberRepository.GetById(id);

                uow.MemberRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public MemberDto Login(LoginDto model)
        {
            MemberDto result = new MemberDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.MemberRepository.GetAll(p => (p.Username == model.UsernameOrEmail || p.Email == model.UsernameOrEmail) && p.Password == model.Password && p.IsActive == true).FirstOrDefault();

                return MapperFactory.Map<Member, MemberDto>(entity);
            }
        }
    }
}
