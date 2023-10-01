using Shop.Core.Interfaces;
using Shop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductViewModel> GetAll()
        {
            var entityProduct = _productRepository.GetAll();
            return entityProduct.Select(e => new ProductViewModel
            {
                Id= e.Id,
                Name = e.Name,
                Description = e.Description,
                CategoryName = e.Category.Name,
                Variants = e.Variants.Select(v=>new ProductVariantVM(v.Id,v.Price,v.Title)).ToList()
            }).ToList();
        }
    }
}
