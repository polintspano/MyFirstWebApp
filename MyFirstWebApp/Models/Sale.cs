using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class Sale : WarehouseDocument
    {
        
        [ForeignKey("Product")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
