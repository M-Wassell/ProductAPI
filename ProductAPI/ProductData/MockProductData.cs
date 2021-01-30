using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.ProductData
{
    public class MockProductData : IProductData
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product one",
                Description = "This is product ONE",
                Price = 10,
                Available = true
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product two",
                Description = "This is product TWO",
                Price = 20,
                Available = true
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product three",
                Description = "This is product THREE",
                Price = 30,
                Available = false
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product four",
                Description = "This is product FOUR",
                Price = 40,
                Available = true
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product five",
                Description = "This is product FIVE",
                Price = 50,
                Available = true
            },
        };
        public Product AddProduct(Product product) 
        {
            product.Id = Guid.NewGuid();
            products.Add(product);
                return product;
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public Product EditProduct(Product product)
        {
            var existingProduct = GetProduct(product.Id);
            existingProduct.Name = product.Name;
            return existingProduct;
        }

        public Product GetProduct(Guid id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
