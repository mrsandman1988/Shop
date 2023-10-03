using Shop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryAddEditViewModel> GetAll();
        CategoryAddEditViewModel Add(CategoryAddEditViewModel model);
  
    }
}
