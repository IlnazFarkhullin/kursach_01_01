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
        public static  List<students_class> ShowStudents()
        {
            var stud = new MongoClient("mongodb://localhost");
            var database = stud.GetDatabase("guide");
            var collection = database.GetCollection<BD_class.students_class>("Students");
            return collection.Find(x => true).ToList();
        }

        public static List<authorization> Authorizations()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("guide");
            var collection = database.GetCollection<authorization>("auth");
            return collection.Find(x => true).ToList();
        }
    }
}
