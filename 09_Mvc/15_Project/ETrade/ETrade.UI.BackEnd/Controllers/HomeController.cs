using ETrade.Dto.Dto.Home;
using ETrade.Service.Enum;
using ETrade.Service.Service;
using ETrade.UI.BackEnd.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Controllers
{
    [UserAuthorize]
    public class HomeController : BaseController
    {
        IPurchaseOrderService _purchaseOrderService;
        IMemberService _memberService;
        IProductService _productService;
        ICategoryService _categoryService;
        public HomeController(IPurchaseOrderService purchaseOrderService,
                               IMemberService memberService,
                               IProductService productService,
                               ICategoryService categoryService)
        {
            _purchaseOrderService = purchaseOrderService;
            _memberService = memberService;
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Dashboard";

            var model = new HomeDto();

            //Yeni Siparişlerin sayısı hesaplanıyor.
            var list = _purchaseOrderService.GetByPurchaseOrderStatusId(PurchaseOrderStatusEnum.SiparisVerildi);
            if (list != null)
            {
                model.NewPurchaseOrderCount = list.Count;
            }

            //Aktif üye sayısı hesaplanıyor.
            var memberList = _memberService.GetActives();
            if (memberList != null)
            {
                model.ActiveMemberCount = memberList.Count;
            }

            //Aktif ürün sayısı hesaplanıyor
            var productList = _productService.GetActives();
            if (productList != null)
            {
                model.ActiveProductCount = productList.Count;
            }

            //Toplam tıklanma sayısı hesaplanıyor.
            model.ProductClickedCount = _productService.GetTotalClickedCount();

            //Donut grafiği için category listesi alınıyor.
            var categoryList = _categoryService.GetActives().Select(p => p.Name).OrderBy(p=> p).ToList();

            model.DonutChartCategoryList = string.Join(",", categoryList);

            //Donut grafiği için satış toplamları alınıyor.
            var quantityList = _purchaseOrderService.GetQuantitiesByCategory();

            model.DonutChartPurchaseQuantityList = string.Join(",", quantityList);

            return View(model);
        }
    }
}