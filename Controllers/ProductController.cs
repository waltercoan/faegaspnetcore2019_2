using System;
using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.Services;

namespace myshop.Controllers
{
    public class ProductController  : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Product product){
            if (ModelState.IsValid)
            {
                this.productService.save(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}