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
        [Required(ErrorMessage ="* Required")]
        public string Name { get; set; }

        [BsonElement("DateOfBirth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "* Required")]
        [_18YearOldValidation]
        public DateTime DateOfBirth { get; set; }

        [BsonElement("PhoneNumber")]
        [Required(ErrorMessage = "* Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public int PhoneNumber { get; set; }

        [BsonElement("City")]
        [Required(ErrorMessage = "* Required")]
        public String City { get; set; }

        [BsonElement("Email")]
        [Required(ErrorMessage = "* Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public String Email { get; set; }
    }
}
