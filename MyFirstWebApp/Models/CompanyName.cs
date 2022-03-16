using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class CompanyName : CommonEntity
    {
        public string Name { get; set; }
        public string Bulstat { get; set; }
        public string VatNumber { get; set; }
    }
}
