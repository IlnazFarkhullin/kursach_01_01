using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using kursach_01_01.BD_class;

namespace kursach_01_01.BD_class
{
    class DataBaseMethods
    {
        public static  List<students_class> ShowStudents()
        {
            var stud = new MongoClient("mongodb://localhost"); // подключение
            var database = stud.GetDatabase("guide"); // бд
            var collection = database.GetCollection<BD_class.students_class>("Students"); // коллекция внутри БД
            return collection.Find(x => true).ToList(); // возвращение всех данных из коллекции
        }

        public static List<notes_class> ShowNotes()
        {
            var notes = new MongoClient("mongodb://localhost");
            var datbase = notes.GetDatabase("guide");
            var collection = datbase.GetCollection<notes_class>("Notes");
            return collection.Find(x => true).ToList();
        }
      

        public static List<authorization> Authorizations()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("guide");
            var collection = database.GetCollection<authorization>("auth");
            return collection.Find(x => true).ToList();
        }

        public static void AddStudentToDatabase(students_class students_)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<students_class>("Students");
            collection.InsertOne(students_);
        }
        public static void RemoveStudentToDatabase(students_class students_)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<students_class>("Students");
            collection.DeleteOne(s=> s.Surname == "" || s.Name == "" || s.Lname== "");

        }
    }
}
