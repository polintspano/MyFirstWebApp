using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class Product : CommonEntity
    {
        [Required]
        [MaxLength(255, ErrorMessage = "Max Product Name length is 255 symbols.")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Unit  { get; set; }


    }
}
