using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String UserId { get; set; }
        
        [BsonElement("Name")]
        [Required]
        public string  Name { get; set; }
       
        [BsonElement("DateOfBirth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
       
        [BsonElement("PhoneNumber")]
        [Required]
        public int PhoneNumber { get; set; }

        [BsonElement("City")]
        [Required]
        public String City { get; set; }

        [BsonElement("Email")]
        [Required]
        public String Email { get; set; }
    }
}
