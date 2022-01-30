using ETrade.Dto.Dto.Basket;
using ETrade.Dto.Dto.BasketDetail;
using ETrade.Dto.Dto.FrontEndHome;
using ETrade.Dto.Dto.Product;
using ETrade.Service.Service;
using ETrade.UI.FrontEnd.Attribute;
using ETrade.UI.FrontEnd.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.FrontEnd.Controllers
{
    [UserAuthorize]
    public class BasketController : BaseController
    {
        IProductService _productService;
        IBasketService _basketService;
        IBasketDetailService _basketDetailService;
        public BasketController(IProductService productService,
                                IBasketService basketService,
                                IBasketDetailService basketDetailService)
        {
            _productService = productService;
            _basketService = basketService;
            _basketDetailService = basketDetailService;
        }

        public ActionResult Index(int? productId, int? quantity)
        {
            quantity = 1;
            var model = new BasketFrontEndDto();
            
            var basket = _basketService.GetByMemberId(SessionHelper.ActiveUser.Id);

            if (productId != null)
            {
                _basketDetailService.Add(new BasketDetailDto
                {
                    BasketId = basket.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    CreatedBy = SessionHelper.ActiveUser.Id
                }); ;
            }

            model.Basket = basket;
            model.BasketDetails = _basketDetailService.GetByBasketId(model.Basket.Id);

            return View(model);
        }

        public ActionResult RemoveProduct(int? productId)
        {
            var model = new BasketFrontEndDto();

            var basket = _basketService.GetByMemberId(SessionHelper.ActiveUser.Id);

            if (productId != null)
            {
                _basketDetailService.DeleteByProductIdBasketId(productId.Value, basket.Id);
            }

            return RedirectToAction("Index", "Basket");
        }
    }
}