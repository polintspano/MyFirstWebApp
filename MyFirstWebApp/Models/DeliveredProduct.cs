using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class DeliveredProduct : WarehouseDcoumentDetails
    {
        [ForeignKey("Delivery")]
        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
