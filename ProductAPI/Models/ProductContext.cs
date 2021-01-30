using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }
        //Products is the name of the DB table 
        public DbSet<Product> Products { get; set; }
    }
}
