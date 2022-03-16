using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class WarehouseDcoumentDetails : CommonEntity
    {
        public double Quantity { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public string VatNumber { get; set; }
    }
}
