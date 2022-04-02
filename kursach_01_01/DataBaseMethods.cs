using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace kursach_01_01
{
    class DataBaseMethods
    {

        public static List<student> ShowStudent(string std)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("test");
            //var collection = database.GetCollection<students>(std);

            IMongoCollection<student> collection = database.GetCollection<student>(std);
            return collection.Find(x => true).ToList();
        }
    }
}
