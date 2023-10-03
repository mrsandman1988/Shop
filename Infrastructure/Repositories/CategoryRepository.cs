using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopDbContext _context;
        public CategoryRepository(ShopDbContext context)
        {
            _context= context;
        }
        public void Add(Category Category, bool saveChanges = true)
        {
            _context.Add(Category);
            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Delete(Category Category)
        {
            _context.Remove(Category);
            SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
            
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
         }
    }
}
