using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightpointTask.BLL.Interfaces;
using LightpointTask.BLL.DTO;
using LightpointTask.Models;
using AutoMapper;
using LightpointTask.BLL.Infrastructure;

namespace LightpointTask.Controllers
{
    public class ShopController : Controller
    {
        IShopService shopService;

        
        public ShopController(IShopService service)
        {
            shopService = service;
        }

        public ActionResult Index()
        {
            IEnumerable<ShopDTO> shopDtos = shopService.GetShops();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ShopDTO, ShopViewModel>()).CreateMapper();
            var shops = mapper.Map<IEnumerable<ShopDTO>, List<ShopViewModel>>(shopDtos);

            return View(shops);
        }
        public ActionResult MakeShop()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeShop(ShopViewModel shop)
        {
            try
            {
                var shopDto = new ShopDTO { Name = shop.Name,TimeWorkFrom = shop.TimeWorkFrom,TimeWorkTo = shop.TimeWorkTo };
                shopService.MakeShop(shopDto);
                //return Content("<h2>Магазин успешно добавлен</h2>");
                return RedirectToAction("index");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(shop);
        }

        public ActionResult DeleteShop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteShop(int id)
        {
            try
            {
                shopService.DeleteShop(id);
                //return Content("<h2>Магазин успешно удален</h2>");
                return RedirectToAction("index");
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
            base.Dispose(disposing);
        }
    }
}