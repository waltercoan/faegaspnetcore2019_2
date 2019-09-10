using System.Collections.Generic;
using MongoDB.Driver;
using myshop.Models;

namespace myshop.Services
{
    public class ProductService : IProductService
    {
        MongoClient con;
        IMongoDatabase db;
        public ProductService()
        {
            con = new MongoClient("mongodb://172.18.0.35:27017");
            db = con.GetDatabase("dbwalter");
            if(db.GetCollection<Product>("Products") == null)
                db.CreateCollection("Products");
        }
        public List<Product> GetAll()
        {
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => true).ToList();
        }
    }
}