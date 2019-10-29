using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.Services;

namespace myshop.Controllers
{
    public class ProductController  : Controller
    {
        private IProductService productService;
        private IStorageService storageService;
        public ProductController(IProductService productService, IStorageService storageService)
        {
            this.productService = productService;
            this.storageService = storageService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var listProduct = this.productService.GetAll();
            return View(listProduct);
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Form(Product product){
            if (ModelState.IsValid)
            {
                var fileName = await this.storageService.saveFile(product.Photo);
                product.FileNameStorage = fileName;
                this.productService.save(product);

                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}