using Northwnd.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Service.Services.Interface
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        ProductDto GetById(int id);
        void Update(ProductDto productDto);
        void Delete(ProductDto productDto);
        void Insert(ProductDto productDto);
    }
}
