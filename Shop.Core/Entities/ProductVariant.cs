using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shop.Core.Entities
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Title { get; set; } 
        [ForeignKey("Product")]
        public int ProductId { get; set; }
       
        public Product Product { get; set; }
    }
}
