using Shop.Core.Entities;
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

        public ProductAddEditViewModel Add(ProductAddEditViewModel model)
        {
            var product = new Product // agregate
            {
                Name= model.Name,
                Description= model.Description,
                CategoryId= model.CategoryId,
                Variants = model.Varaints.Select(v => new ProductVariant
                {
                    Price= v.Price,
                    Title= v.Title
                }).ToList()
            };
            _productRepository.Add(product, true);

            return MapProductToViewModel(product);
        }

        public void DeleteById(int id)
        {
            var entity = _productRepository.GetById(id);
            _productRepository.Delete(entity);
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

        public ProductAddEditViewModel GetById(int id)
        {
            var entity = _productRepository.GetById(id);
           return MapProductToViewModel(entity);
        }

        public ProductAddEditViewModel Update(ProductAddEditViewModel model)
        {
            var entity = _productRepository.GetById(model.Id);
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.CategoryId= model.CategoryId;
            entity.Variants = model.Varaints
                .Select(v => new ProductVariant
                {
                    Price = v.Price,
                    Title = v.Title,

                }).ToList();
            _productRepository.SaveChanges();
            return MapProductToViewModel(entity);
        }

        private ProductAddEditViewModel MapProductToViewModel(Product entity)
        {
            if(entity == null)
            {
                return null;
            }
            // refactoring
            return new ProductAddEditViewModel

            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                CategoryId = entity.CategoryId,
                Varaints = entity.Variants.Select(v => new VaraintAddEditViewModel
                {
                    Id = v.Id,
                    Price = v.Price,
                    Title = v.Title
                }).ToList()
            };
        }

    }
}
