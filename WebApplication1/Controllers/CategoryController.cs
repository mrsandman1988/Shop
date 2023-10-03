using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Interfaces;
using Shop.Core.ViewModels;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
           var data =  _service.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Add(CategoryAddEditViewModel model) 
        {
            var data = _service.Add(model);
            return Ok(data);
        }
    }
}
