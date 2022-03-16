using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class SoldProduct : WarehouseDcoumentDetails
    {
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

    }
}
