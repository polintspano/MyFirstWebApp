using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class Client : CommonEntity
    {
        
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
