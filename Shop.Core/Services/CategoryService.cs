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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        {
            _repository= repository;
        }
        public CategoryAddEditViewModel Add(CategoryAddEditViewModel model)
        {
            Category category = new Category()
            {
                Name = model.Name,
            };
            _repository.Add(category);
            return new CategoryAddEditViewModel
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public List<CategoryAddEditViewModel> GetAll()
        {
            var entityCategory = _repository.GetAll();
            return entityCategory.Select(c => new CategoryAddEditViewModel
            {
               Id = c.Id,
                Name = c.Name
            }).ToList();
        }
    }
}
