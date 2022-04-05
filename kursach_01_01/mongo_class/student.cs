using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Core;
namespace kursach_01_01
{
    class student
    {
        public student(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("age")]
        public int age { get; set; }
    }
}
