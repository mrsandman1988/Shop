using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product,  bool saveChanges = true);
        List<Product> GetAll();
        Product GetById(int id);
        void Delete(Product product);
        void SaveChanges();
    }
}
