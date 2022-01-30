using AutoMapper;
using ETrade.Data.Context;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.Basket;
using ETrade.Dto.Dto.BasketDetail;
using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.Employee;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Member;
using ETrade.Dto.Dto.Product;
using ETrade.Dto.Dto.ProductImage;
using ETrade.Dto.Dto.PurchaseOrder;
using ETrade.Dto.Dto.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Mapper
{
    public static class MapperFactory
    {
        private static MapperConfiguration mapperConfiguration;
        private static bool _isInitialized;
        private static object lck = new object();

        public static K Map<T, K>(T input)
        {
            Init();

            IMapper mapper = mapperConfiguration.CreateMapper();

            return input != null ? mapper.Map<T, K>(input) : default(K);
        }

        private static void Init()
        {
            lock(lck)
            {
                if (_isInitialized) return;

                mapperConfiguration = new MapperConfiguration(p =>
                {
                    p.CreateMap<Member, MemberDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Employee, EmployeeDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<EmployeeType, EmployeeTypeDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Category, CategoryDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Product, ProductDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Supplier, SupplierDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<PurchaseOrder, PurchaseOrderDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<ProductImage, ProductImageDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Basket, BasketDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<BasketDetail, BasketDetailDto>().MaxDepth(1).ReverseMap();
                });
            }

            _isInitialized = true;
        }
    }
}
