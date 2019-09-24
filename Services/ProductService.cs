using System;
using System.Collections.Generic;
using MongoDB.Bson;
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
            //con = new MongoClient("mongodb://172.18.0.35:27017");
            con = new MongoClient("mongodb://localhost:27017");
            db = con.GetDatabase("dbwalter");
            if(db.GetCollection<Product>("Products") == null)
                db.CreateCollection("Products");
        }
        public List<Product> GetAll()
        {
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => true).ToList();
        }
        public List<Product> GetAllByName(string name){
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public void save(Product product)
        {
            var collection = db.GetCollection<Product>("Products");
            if(product.Id == null | product.Id == String.Empty)
                collection.InsertOne(product);
            else{
                var filter = Builders<Product>.Filter.Eq("Id", product.Id);
                var updateDefinition = Builders<Product>.Update
                        .Set(p => p.Name, product.Name)
                        .Set(p => p.Description, product.Description)
                        .Set(p => p.Price, product.Price);
                collection.UpdateOne(filter,updateDefinition);
            }
        }
    }
}