using System;
using MongoDB.Driver;
using myshop.Models;

namespace myshop.Services
{
    public class UserService : IUserService
    {
        MongoClient con;
        IMongoDatabase db;
        public UserService()
        {
            con = new MongoClient("mongodb://172.18.0.35:27017");
            //con = new MongoClient("mongodb://localhost:27017");
            db = con.GetDatabase("dbwalter");
            if(db.GetCollection<User>("Users") == null)
                db.CreateCollection("Users");
        }
        public User getUserByName(string name)
        {
            var collection = db.GetCollection<User>("Users");
            return collection.Find<User>(p => p.UserName.ToLower().Contains(name.ToLower())).FirstOrDefault();
        }

        public User save(User user)
        {
            var collection = db.GetCollection<User>("Users");
            if(user.Id == null | user.Id == String.Empty)
                collection.InsertOne(user);
            else{
                var filter = Builders<User>.Filter.Eq("Id", user.Id);
                var updateDefinition = Builders<User>.Update
                        .Set(p => p.UserName, user.UserName)
                        .Set(p => p.UserPassword, user.UserPassword);
                collection.UpdateOne(filter,updateDefinition);
            }
            return user;
        }
    }
}