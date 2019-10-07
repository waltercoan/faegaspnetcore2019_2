using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using myshop.Models;

namespace myshop.Services
{
    public class ProductService : IProductService
    {
        MongoClient con;
        IMongoDatabase db;
        public ProductService([FromServices]MongoConfiguration mongoConfiguration)
        {
            con = new MongoClient(mongoConfiguration.Connection);
            db = con.GetDatabase("dbwalter");
            if(db.GetCollection<Product>("Products") == null)
                db.CreateCollection("Products");
        }
        public List<Product> GetAll()
        {
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => true).ToList();
        }
        public Product GetById(string id)
        {
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => p.Id == id).FirstOrDefault();
        }
       
        public List<Product> GetAllByName(string name){
            var collection = db.GetCollection<Product>("Products");
            return collection.Find<Product>(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public Product save(Product product)
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
            return product;
        }
        public void delete(string id)
        {
            var collection = db.GetCollection<Product>("Products");
            collection.DeleteOne<Product>(p => p.Id == id);
        }
    }
}