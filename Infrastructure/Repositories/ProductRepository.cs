using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Interfaces;
namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _context;

        public ProductRepository(ShopDbContext context)
        {
            _context = context;
        }
        public void Add(Product product, bool saveChanges = true)
        {
            _context.Products.Add(product);
            if(saveChanges)
            {
                _context.SaveChanges();
            }
           
        }

        public void Delete(Product product)
        {
           _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(p=>p.Variants)
                .Include(p=>p.Category)
                .ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Include(p => p.Variants)
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

        }

        public void SaveChanges()
        {
           _context.SaveChanges();
        }
    }
}
