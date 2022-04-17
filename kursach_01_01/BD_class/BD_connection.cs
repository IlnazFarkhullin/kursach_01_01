using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace kursach_01_01.BD_class
{
   public  class BD_connection
    {
        private static string _connectionString = "mongodb://localhost:27017";
        private static MongoClient _client = new MongoClient(_connectionString);
        IMongoClient MongoClient = (IMongoClient)_client.GetDatabase("test");
    }
}
