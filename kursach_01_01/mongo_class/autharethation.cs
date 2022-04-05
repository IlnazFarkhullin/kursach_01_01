using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Core;


namespace kursach_01_01.mongo_class
{
    class autharethation
    {
        public autharethation(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        
        [BsonElement("login")]
        public string login { get; set; }

        [BsonElement("password")]
        public string password { get; set; }


    }
}
