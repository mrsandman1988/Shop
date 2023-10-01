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
    }
}
