using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyEshop.Models
{
    public class AddEditProductViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "نام محصول")]
        public string Name { get; set; }

        [Display(Name = "توضیحات محصول")]
        public string Description { get; set; }

        [Display(Name = "قیمت محصول")]
        public decimal Price { get; set; }

        [Display(Name = "موجودی")]
        public int QuantityInStock { get; set; }
        public IFormFile Picture { get; set; }
        public List<Category> Categories { get; set; }
        

    }
}
