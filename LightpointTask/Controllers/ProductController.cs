using System.Collections.Generic;
using System.Web.Mvc;
using LightpointTask.BLL.Interfaces;
using LightpointTask.BLL.DTO;
using LightpointTask.Models;
using AutoMapper;
using LightpointTask.BLL.Infrastructure;

namespace LightpointTask.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;

        public ProductController(IProductService service)
        {
            productService = service;
        }

        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<ProductDTO> productDtos = productService.GetProducts();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();
            var shops = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDtos);

            return View(shops);
        }

        public ActionResult MakeProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeProduct(ProductViewModel product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var productDto = new ProductDTO { Name = product.Name, Description = product.Description };
                    productService.MakeProduct(productDto);
                    //return Content("<h2>Магазин успешно добавлен</h2>");
                    return RedirectToAction("index");
                }
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(product);
        }

        public ActionResult DeleteProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                productService.DeleteProduct(id);
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
            productService.Dispose();
            base.Dispose(disposing);
        }
    }
}