using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Core.ViewModels;
namespace Shop.Core.Interfaces
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();
        ProductAddEditViewModel Add(ProductAddEditViewModel model);
        ProductAddEditViewModel GetById(int id);
        ProductAddEditViewModel Update(ProductAddEditViewModel model);
        void DeleteById(int id);
    }
}
