﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ViewModels
{
    public class ProductAddEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public List<VaraintAddEditViewModel> Varaints { get; set; } = new();
    }

    public class VaraintAddEditViewModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
       
    }
}
