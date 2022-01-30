using AutoMapper;
using ETrade.Data.Context;
using ETrade.Data.UnitOfWork;
using ETrade.Dto.Dto;
using ETrade.Dto.Dto.PurchaseOrder;
using ETrade.Service.Enum;
using ETrade.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Service.Service
{
    public interface IPurchaseOrderService
    {
        List<PurchaseOrderDto> GetAll();
        PurchaseOrderDto GetById(int id);
        void Add(PurchaseOrderDto dto);
        void Update(PurchaseOrderDto dto);
        void Delete(int id);
        List<PurchaseOrderDto> Search(PurchaseOrderSearchDto model);
        List<PurchaseOrderDto> GetByPurchaseOrderStatusId(PurchaseOrderStatusEnum purchaseOrderStatus);
        List<int?> GetQuantitiesByCategory();
    }

    public class PurchaseOrderService : IPurchaseOrderService
    {
        public List<PurchaseOrderDto> GetAll()
        {
            List<PurchaseOrderDto> result = new List<PurchaseOrderDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>).ToList();
            }
        }

        public PurchaseOrderDto GetById(int id)
        {
            PurchaseOrderDto result = new PurchaseOrderDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderRepository.GetById(id);

                return MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>(entity);
            }
        }

        public void Add(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDto, PurchaseOrder>(dto);

                uow.PurchaseOrderRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDto, PurchaseOrder>(dto);

                uow.PurchaseOrderRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderRepository.GetById(id);

                uow.PurchaseOrderRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<PurchaseOrderDto> Search(PurchaseOrderSearchDto model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderRepository.GetAll();

                //if (!string.IsNullOrEmpty(model.Name))
                //{
                //    list = list.Where(p => p.Name.Contains(model.Name));
                //}

                var result = list.ToList();

                return result.Select(MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>).ToList();
            }
        }

        public List<PurchaseOrderDto> GetByPurchaseOrderStatusId(PurchaseOrderStatusEnum purchaseOrderStatus)
        {
            List<PurchaseOrderDto> result = new List<PurchaseOrderDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderRepository.GetAll(p=> p.PurchaseOrderStatusId == (int)purchaseOrderStatus).ToList();
                return list.Select(MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>).ToList();
            }
        }

        public List<int?> GetQuantitiesByCategory()
        {
            List<PurchaseOrderDto> result = new List<PurchaseOrderDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                //Satış detaylarının hepsi çekiliyor
                var purchaseOrderDetail = uow.PurchaseOrderDetailRepository.GetAll();
                //var list = uow.PurchaseOrderRepository.GetAll();

                //Kategori listesi donut chart'ın üst kısmında görüntülendiği şekliyle aynı sıralamada olacak şekilde çekiliyor
                var categoryList = uow.CategoryRepository.GetAll(p => p.IsActive == true).OrderBy(p=> p.Name).ToList();

                //Her bir kategori için kaç adet ürün satışı gerçekleştirilmişse hesaplanarak listeye ekleniyor.
                List<int?> purchaseOrderCount = new List<int?>();
                foreach (var category in categoryList)
                {
                    var pod = purchaseOrderDetail.Where(p=>p.Product.CategoryId == category.Id);
                    purchaseOrderCount.Add(pod.Sum(p=> p.Quantity));
                }

                return purchaseOrderCount;
            }
        }
    }
}
