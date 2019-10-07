using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.Services;

namespace myshop.Controllers
{
    [Authorize("Bearer")]
    [Route("api/product")]
    public class ProductAPIController : Controller
    {
        private IProductService productService;
        public ProductAPIController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.GetAll();
        }

        [HttpGet("{id}")]
        public Product GetById(string Id){
            return productService.GetById(Id);
        }

        [HttpPost]
        public Product PostProduct([FromBody]Product product){
            return productService.save(product);
        }

        [HttpPut("{id}")]
        public Product PutProduct(string id, [FromBody]Product product){
            if (!id.Equals(product.Id))
            {
                return null;
            }
            return productService.save(product);
        }
        
        [HttpDelete("{id}")]
        public void DeleteProduct(string id){
            productService.delete(id);
        }
    }
}