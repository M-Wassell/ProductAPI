using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }
        
        public String Description { get; set; }

        [Required]
        public double Price { get; set; }

        //[Required]
        public Boolean Available { get; set; }
    }
}
