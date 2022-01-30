using Northwnd.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Service.Services.Interface
{
    public interface IPersonelService
    {
        List<PersonelDto> GetAll();
        PersonelDto GetById(int id);
        void Update(PersonelDto personelDto);
        void Delete(PersonelDto personelDto);
        void Insert(PersonelDto personelDto);
    }
}
