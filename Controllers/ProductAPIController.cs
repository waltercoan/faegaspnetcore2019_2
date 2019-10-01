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
    }
}