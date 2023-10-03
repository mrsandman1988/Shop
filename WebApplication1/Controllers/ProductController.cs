using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Interfaces;
using Shop.Core.Services;
using Shop.Core.ViewModels;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
             var Data = _productService.GetAll();
            return Ok(Data);
        }

        [HttpPost]
        public IActionResult Add(ProductAddEditViewModel model)
        {
            
            var data = _productService.Add(model);
            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _productService.GetById(id);
            if(data is null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update(ProductAddEditViewModel model)
        {
            var data = _productService.Update(model);
            return Ok(data);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           _productService.DeleteById(id);
            return Ok();
        }
    }
}
