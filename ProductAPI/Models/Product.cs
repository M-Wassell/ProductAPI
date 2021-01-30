using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public String Name { get; set; }
        
        public String Description { get; set; }

        public double Price { get; set; }

        public Boolean Available { get; set; }
    }
}
