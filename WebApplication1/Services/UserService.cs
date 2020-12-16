using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> users;

        public UserService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("UserDb"));
            IMongoDatabase database = client.GetDatabase("UserDb");
            users = database.GetCollection<User>("Users");
        }

        public List<User> Get()
        {
            return this.users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return users.Find(user => user.UserId == id).FirstOrDefault();
        }

        public User Create(User user)
        {
            users.InsertOne(user);
            return user;
        }
        
        public void Update(string id, User newUser)
        {
            
            users.ReplaceOne(user => user.UserId == id, newUser);
        }
      
        public void Remove(string id)
        {
            users.DeleteOne(user => user.UserId == id);
        }
    }
}
