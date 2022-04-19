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
    class students_class
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public students_class(ObjectId id, string name)
        {
            _id = id;
            Name = name;
        }
        [BsonElement("name")]
        public string Name { get; set; }
        public int age { get; set; }
    }
}
