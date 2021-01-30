using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.ProductData
{
    public interface IProductData
    {
        List<Product> GetProducts();

        Product GetProduct(Guid id);

        Product AddProduct(Product product);

        void DeleteProduct(Product product);

        Product EditProduct(Product product);
    }
}
