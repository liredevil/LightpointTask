using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightpointTask.BLL.Interfaces;
using LightpointTask.BLL.DTO;
using LightpointTask.Models;
using LightpointTask.BLL.Infrastructure;
using AutoMapper;

namespace LightpointTask.Controllers
{
    public class HomeController : Controller
    {
        IShopService shopService;
        IShopProductService shopProductService;

        public HomeController(IShopService shopService, IShopProductService shopProductService)
        {
            this.shopService = shopService;
            this.shopProductService = shopProductService;
        }
        public ActionResult Index()
        {
            IEnumerable<ShopDTO> shopDtos = shopService.GetShops();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ShopDTO, ShopViewModel>()).CreateMapper();
            var shops = mapper.Map<IEnumerable<ShopDTO>, List<ShopViewModel>>(shopDtos);

            return View(shops);
        }

        public ActionResult ShowProductShop(int id)
        {
            try
            {
                IEnumerable<ProductDTO> productDtos = shopProductService.GetProductById(id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();
                var products = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDtos);

                //return Content("<h2>Магазин успешно удален</h2>");
                return View(products);
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }

            return RedirectToAction("index");
        }


        protected override void Dispose(bool disposing)
        {
            shopService.Dispose();
            shopProductService.Dispose();
            base.Dispose(disposing);
        }


    }
}