using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Interfaces
{
    public interface ICategoryRepository
    {
        void Add(Category Category, bool saveChanges = true);
        List<Category> GetAll();
        Category GetById(int id);
        void Delete(Category Category);
        void SaveChanges();
    }
}
