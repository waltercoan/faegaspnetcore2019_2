using System.Collections.Generic;
using myshop.Models;

namespace myshop.Services
{
    public interface IProductService
    {
         List<Product> GetAll();
         List<Product> GetAllByName(string name);
    }
}