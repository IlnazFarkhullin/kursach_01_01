using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace kursach_01_01.BD_class
{
    class DataBaseMethods
    {
        public static List<students_class> ShowStudents()
        {
            var stud = new MongoClient("mongodb://localhost");
            var database = stud.GetDatabase("MDK_01_01_K");
            var collection = database.GetCollection<students_class>("Products");
            return collection.Find(x => true).ToList();
        }
    }
}
