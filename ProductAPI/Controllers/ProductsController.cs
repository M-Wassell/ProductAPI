using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.ProductData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    
    public class ProductsController : ControllerBase
    {
        private readonly IProductData _productData;

        public ProductsController(IProductData productData)
        {
            _productData = productData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetProducts()
        {
            return Ok(_productData.GetProducts());// try this in the App to use the API
        }


        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetProduct(Guid id)
        {
            var product = _productData.GetProduct(id);
            if(product !=null)
            {
                return Ok(product);
            }
            return NotFound($"Product with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetProduct(Product product)
        {
            _productData.AddProduct(product);
            
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + 
                HttpContext.Request.Path + "/" + product.Id, product);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var product = _productData.GetProduct(id);

            if(product !=null)
            {
                _productData.DeleteProduct(product);
                return Ok();
            }

            return NotFound($"Employee with Id:{id} was not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditProduct(Guid id, Product product)
        {
            var existingProduct = _productData.GetProduct(id);
            if(existingProduct !=null)
            {
                product.Id = existingProduct.Id;
                _productData.EditProduct(product);
            }
            return Ok(product);
        }
    }
}
