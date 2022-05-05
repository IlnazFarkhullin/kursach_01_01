using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kursach_01_01.BD_class
{
    class authorization
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public authorization(ObjectId id, string login, string password, string name)
        {
            _id = id;
            this.login = login;
            this.password = password;
            this.name = name;
        }

        public string  login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        
    }
}
